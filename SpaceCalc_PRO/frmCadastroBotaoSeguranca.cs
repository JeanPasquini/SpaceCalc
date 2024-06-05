using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceCalc_PRO
{
    public partial class frmCadastroBotaoSeguranca : Form
    {
        private string id;
        private bool editar;

        public frmCadastroBotaoSeguranca(string id, bool editar)
        {
            InitializeComponent();
            this.id = id;
            this.editar = editar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                // Recupere o documento existente da coleção "users" pelo ID
                var existingDocument = await MongoDB.selectID("ZBOTAOSEGURANCA", id);

                if (existingDocument != null)
                {
                    // Atualize os campos necessários no documento existente
                    existingDocument["CODIGOBOTAO"] = txtCodigoBotao.Text;
                    existingDocument["NOMEBOTAO"] = txtNomeBotao.Text;
                    existingDocument["DESCRICAOBOTAO"] = txtDescricaoBotao.Text;

                    // Atualize o documento na coleção "users"
                    bool updateResult = await MongoDB.updateDT("ZBOTAOSEGURANCA", id, existingDocument);

                    if (updateResult)
                    {
                        Console.WriteLine("Documento atualizado com sucesso na coleção 'ZBOTAOSEGURANCA'!");
                    }
                    else
                    {
                        Console.WriteLine("Erro ao atualizar o documento na coleção 'ZBOTAOSEGURANCA'.");
                    }

                    this.Close();
                }
                else
                {
                    Console.WriteLine("Documento não encontrado na coleção 'ZPRODUTO'.");
                }
            }
            else
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtCodigoBotao.Text) && !String.IsNullOrEmpty(txtNomeBotao.Text) && !String.IsNullOrEmpty(txtDescricaoBotao.Text))
                    {

                        var document = new BsonDocument
                        {
                            { "CODIGOBOTAO", txtCodigoBotao.Text },
                            { "NOMEBOTAO", txtNomeBotao.Text },
                            { "DESCRICAOBOTAO", txtDescricaoBotao.Text }
                        };

                        await MongoDB.insertDT("ZBOTAOSEGURANCA", document);

                        Console.WriteLine("Documento inserido com sucesso na coleção 'ZBOTAOSEGURANCA'!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos para cadastrar um produto.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Houve um erro:" + er.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void frmCadastro_Load(object sender, EventArgs e)
        {
            string collectionName = "ZBOTAOSEGURANCA"; // Substitua pelo nome da sua coleção MongoDB

            var document = await MongoDB.selectID(collectionName, id);

            if (document != null)
            {
                // Acessar os campos específicos do documento
                string ID = document.Contains("_id") ? document["_id"].ToString() : string.Empty;
                string CODIGOBOTAO = document.Contains("CODIGOBOTAO") ? document["CODIGOBOTAO"].AsString : string.Empty;
                string NOMEBOTAO = document.Contains("NOMEBOTAO") ? document["NOMEBOTAO"].AsString : string.Empty;
                string DESCRICAOBOTAO = document.Contains("DESCRICAOBOTAO") ? document["DESCRICAOBOTAO"].AsString : string.Empty;

                // Exibir ou usar os valores obtidos
                txtID.Text = ID;
                txtCodigoBotao.Text = CODIGOBOTAO;
                txtNomeBotao.Text = NOMEBOTAO;
                txtDescricaoBotao.Text = DESCRICAOBOTAO;
            }
        }
    }
}