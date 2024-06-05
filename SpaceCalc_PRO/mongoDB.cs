using Krypton.Toolkit;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SpaceCalc_PRO
{
    public class MongoDB
    {
        private static IMongoClient _client;
        private static IMongoDatabase _database;
        private static string _dataBase;

        public static void InicializarConexao(string connectionString, string databaseName)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase(databaseName);
            _dataBase = databaseName;
        }

        private static (string, string, string, string) GetParameters()
        {
            try
            {
                string path = String.Format(@"{0}{1}", AppDomain.CurrentDomain.BaseDirectory, "config.xml");
                var doc = XDocument.Load(path);

                var username = doc.Element("Configuracao")?
                                    .Element("MongoDB")?
                                    .Element("username")?.Value;

                var password = doc.Element("Configuracao")?
                                    .Element("MongoDB")?
                                    .Element("password")?.Value;

                var databaseName = doc.Element("Configuracao")?
                                    .Element("MongoDB")?
                                    .Element("databasename")?.Value;

                var authSource = doc.Element("Configuracao")?
                                    .Element("MongoDB")?
                                    .Element("authsource")?.Value;

                _dataBase = databaseName;

                return (username, password, databaseName, authSource);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return ("", "", "", "");
            }
        }

        public static MongoClient GetClient()
        {
            try
            {
                var (username, password, _, _) = GetParameters();

                string connectionString = $"";

                MongoClientSettings settings = MongoClientSettings.FromConnectionString(connectionString);
                settings.ServerApi = new ServerApi(ServerApiVersion.V1);

                return new MongoClient(settings);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter a string de conexão com o MongoDB: " + ex.Message, ex);
            }
        }

        public static async Task<List<BsonDocument>> GetAllDocumentsAsync(string collectionName)
        {
            try
            {
                var database = GetClient().GetDatabase(_dataBase);
                var collection = database.GetCollection<BsonDocument>(collectionName);

                return await collection.Find(new BsonDocument()).ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        public static async Task<DataTable> DT(string tabela)
        {
            try
            {
                string collectionName = tabela;

                var documents = await GetAllDocumentsAsync(collectionName);

                if (documents != null)
                {
                    DataTable table = new DataTable();

                    if (documents.Count > 0)
                    {
                        foreach (var element in documents[0].Elements)
                        {
                            table.Columns.Add(element.Name);
                        }
                    }

                    foreach (var document in documents)
                    {
                        DataRow row = table.NewRow();
                        foreach (var element in document.Elements)
                        {
                            row[element.Name] = element.Value.ToString();
                        }
                        table.Rows.Add(row);
                    }

                    return table;
                }
                else
                {
                    MessageBox.Show("Erro ao recuperar os documentos da coleção.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        public static async Task<DataTable> DTWhere(string tabela, Dictionary<string, string> filtros)
        {
            try
            {
                string collectionName = tabela;

                DataTable table = await DT(collectionName);

                if (table != null)
                {
                    // Constrói a condição de filtro
                    string filterExpression = string.Join(" AND ", filtros.Select(kv => $"{kv.Key} = '{kv.Value}'"));

                    // Filtra os dados
                    DataRow[] filteredRows = table.Select(filterExpression);

                    // Cria um novo DataTable para os resultados filtrados
                    DataTable filteredTable = table.Clone(); // Clona a estrutura do DataTable original

                    foreach (DataRow row in filteredRows)
                    {
                        filteredTable.ImportRow(row);
                    }

                    return filteredTable;
                }
                else
                {
                    MessageBox.Show("Erro ao recuperar os documentos da coleção.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        public static async Task<string> DTWhereAsString(string tabela, Dictionary<string, string> filtros, string coluna)
        {
            try
            {
                DataTable filteredTable = await DTWhere(tabela, filtros);

                if (filteredTable != null)
                {
                    StringBuilder result = new StringBuilder();

                    // Obtém o índice da coluna desejada
                    int columnIndex = filteredTable.Columns.IndexOf(coluna);

                    if (columnIndex != -1)
                    {
                        // Adiciona os dados da coluna especificada
                        foreach (DataRow row in filteredTable.Rows)
                        {
                            result.Append(row[columnIndex].ToString());
                        }

                        return result.ToString();
                    }
                    else
                    {
                        return $"A coluna '{coluna}' não foi encontrada na tabela.";
                    }
                }
                else
                {
                    return "Erro ao recuperar os documentos da coleção.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }

        }

        public static async Task<BsonDocument> selectID(string collectionName, string id)
        {
            try
            {
                var database = GetClient().GetDatabase(_dataBase);
                var collection = database.GetCollection<BsonDocument>(collectionName);

                var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));

                return await collection.Find(filter).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        public static async Task insertDT(string collectionName, BsonDocument document)
        {
            try
            {
                var database = GetClient().GetDatabase(_dataBase);
                var collection = database.GetCollection<BsonDocument>(collectionName);

                await collection.InsertOneAsync(document);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static async Task<bool> updateDT(string collectionName, string id, BsonDocument document)
        {
            try
            {
                var database = GetClient().GetDatabase(_dataBase);
                var collection = database.GetCollection<BsonDocument>(collectionName);

                var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
                var updateResult = await collection.ReplaceOneAsync(filter, document);

                return updateResult.ModifiedCount == 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> deleteDT(string collectionName, string id)
        {
            try
            {
                var database = GetClient().GetDatabase(_dataBase);
                var collection = database.GetCollection<BsonDocument>(collectionName);

                var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
                var deleteResult = await collection.DeleteOneAsync(filter);

                return deleteResult.DeletedCount == 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static async Task<DataTable> InnerJoin(DataTable table1, DataTable table2, string joinColumn1, string joinColumn2)
        {
            DataTable resultTable = new DataTable();

            try
            {
                // Adicionar colunas da primeira tabela ao resultado
                foreach (DataColumn column in table1.Columns)
                {
                    resultTable.Columns.Add(column.ColumnName, column.DataType);
                }

                // Adicionar colunas da segunda tabela ao resultado (exceto a coluna de junção)
                foreach (DataColumn column in table2.Columns)
                {
                    if (!resultTable.Columns.Contains(column.ColumnName))
                    {
                        resultTable.Columns.Add(column.ColumnName, column.DataType);
                    }
                }

                // Realizar a junção interna
                var joinedRows = from row1 in table1.AsEnumerable()
                                 join row2 in table2.AsEnumerable()
                                 on row1.Field<object>(joinColumn1) equals row2.Field<object>(joinColumn2)
                                 select row1.ItemArray.Concat(row2.ItemArray.Where((item, index) => table2.Columns[index].ColumnName != joinColumn2)).ToArray();

                // Adicionar as linhas ao resultado
                foreach (var rowArray in joinedRows)
                {
                    resultTable.Rows.Add(rowArray);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return resultTable;
        }

        public static async Task<DataTable> FilterColumns(DataTable originalTable, params string[] columnsToInclude)
        {
            DataTable filteredTable = new DataTable();

            try
            {
                // Adicionar as colunas especificadas ao resultado
                foreach (string columnName in columnsToInclude)
                {
                    if (originalTable.Columns.Contains(columnName))
                    {
                        filteredTable.Columns.Add(columnName, originalTable.Columns[columnName].DataType);
                    }
                    else
                    {
                        throw new ArgumentException($"A coluna '{columnName}' não existe na tabela original.");
                    }
                }

                // Adicionar as linhas ao resultado
                foreach (DataRow row in originalTable.Rows)
                {
                    DataRow newRow = filteredTable.NewRow();
                    foreach (string columnName in columnsToInclude)
                    {
                        newRow[columnName] = row[columnName];
                    }
                    filteredTable.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return filteredTable;
        }
    }
}
