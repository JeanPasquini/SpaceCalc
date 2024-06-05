using Krypton.Toolkit;
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
    public partial class frmCadastroPedido : Form
    {
        private string id;
        private bool editar;
        private bool save;

        public frmCadastroPedido(string id, bool editar)
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
                var existingDocument = await MongoDB.selectID("ZPEDIDOS", id);

                if (existingDocument != null)
                {
                    existingDocument["CODIGOPEDIDO"] = txtPedidoCodigo.Text;
                    existingDocument["NOMEPEDIDO"] = txtPedidoDescricao.Text;
                    existingDocument["OBSERVACAOPEDIDO"] = txtObservacaoPedido.Text;

                    bool updateResult = await MongoDB.updateDT("ZPEDIDOS", id, existingDocument);

                    if (updateResult)
                    {
                        Console.WriteLine("Documento atualizado com sucesso na coleção 'ZPEDIDOS'!");
                        MessageBox.Show("Salvo com sucesso!", "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Console.WriteLine("Erro ao atualizar o documento na coleção 'ZPEDIDOS'.");
                    }
                }
                else
                {
                    Console.WriteLine("Documento não encontrado na coleção 'ZPEDIDOS'.");
                }
            }
            else
            {
                try
                {
                    if (!String.IsNullOrEmpty(txtPedidoCodigo.Text) && !String.IsNullOrEmpty(txtPedidoDescricao.Text) && !String.IsNullOrEmpty(txtObservacaoPedido.Text))
                    {

                        var document = new BsonDocument
                        {
                            {"CODIGOPEDIDO", txtPedidoCodigo.Text },
                            {"NOMEPEDIDO", txtPedidoDescricao.Text },
                            {"OBSERVACAOPEDIDO" , txtObservacaoPedido.Text},
                            {"IDUSUARIODECRIACAO", session.idusuario }
                        };

                        await MongoDB.insertDT("ZPEDIDOS", document);

                        var idDoDocumentoInserido = document["_id"];

                        id = idDoDocumentoInserido.ToString();
                        txtIDPedido.Text = id;
                        save = true;
                        editar = true;

                        Console.WriteLine("Documento inserido com sucesso na coleção 'ZPEDIDOS'!");
                        MessageBox.Show("Salvo com sucesso!", "Informação do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos para cadastrar um pedido.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Houve um erro:" + er.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void frmCadastroProduto_Load(object sender, EventArgs e)
        {

            if (editar)
            {
                string collectionName = "ZPEDIDOS";
                string collectionNameUsuario = "ZUSUARIO";

                var document = await MongoDB.selectID(collectionName, id);
                

                if (document != null)
                {
                    string ID = document.Contains("_id") ? document["_id"].ToString() : string.Empty;
                    string CODIGO = document.Contains("CODIGOPEDIDO") ? document["CODIGOPEDIDO"].AsString : string.Empty;
                    string NOMEPEDIDO = document.Contains("NOMEPEDIDO") ? document["NOMEPEDIDO"].AsString : string.Empty;
                    string OBSERVACAOPEDIDO = document.Contains("OBSERVACAOPEDIDO") ? document["OBSERVACAOPEDIDO"].AsString : string.Empty;
                    string IDUSUARIODECRIACAO = document.Contains("IDUSUARIODECRIACAO") ? document["IDUSUARIODECRIACAO"].AsString : string.Empty;

                    txtIDPedido.Text = ID;
                    txtPedidoCodigo.Text = CODIGO;
                    txtPedidoDescricao.Text = NOMEPEDIDO;
                    txtObservacaoPedido.Text = OBSERVACAOPEDIDO;
                    txtIDNome.Text = IDUSUARIODECRIACAO;
                    var documentUsuario = await MongoDB.selectID(collectionNameUsuario, IDUSUARIODECRIACAO);

                    if (documentUsuario != null)
                    {
                        string NOMEUSUARIO = documentUsuario.Contains("USUARIO") ? documentUsuario["USUARIO"].AsString : string.Empty;
                        txtNome.Text = NOMEUSUARIO;
                    }

                    atualizaGrid();
                }


            }
            else
            {
                txtIDNome.Text = session.idusuario;
                txtNome.Text = session.account;
            }
            save = editar == true ? true : false;
        }

        private async void atualizaGrid()
        {
            try
            {
                showWaitForm.Open();
                Dictionary<string, string> filtros = new Dictionary<string, string>();
                filtros.Add("IDPEDIDO", id);

                DataTable table = await MongoDB.DTWhere("ZPEDIDOSITEM", filtros);

                DataTable table2 = await MongoDB.DT("ZPRODUTO");

                DataTable Final = await MongoDB.InnerJoin(table, table2, "IDPRODUTO", "_id");

                string[] columnsToInclude = { "IDPRODUTO", "CODIGO", "NOMEFANTASIA", "QUANTIDADE" };

                DataTable filter = await MongoDB.FilterColumns(Final, columnsToInclude);

                if (table != null)
                    {
                        kryptonDataGridView1.DataSource = filter;
                    }
                    else
                    {
                        Console.WriteLine("Erro ao preencher o DataGridView.");
                    }
                    showWaitForm.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Houve um erro:" + er.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void kryptonGroupBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (save)
            {
                frmCadastroProdutoCompl frm = new frmCadastroProdutoCompl(id);
                frm.ShowDialog();
                atualizaGrid();
            }
            else
            {
                MessageBox.Show("Você deve salvar o pedido antes de adicionar um produto", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonDataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = kryptonDataGridView1.SelectedRows[0];

                    string id = selectedRow.Cells[0].Value.ToString();

                    DialogResult result = MessageBox.Show($@"Deseja exclui o Produto de ID: {id}?", "Pergunta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        bool deleteResult = await MongoDB.deleteDT("ZPEDIDOSITEM", id);

                        if (deleteResult)
                        {
                            MessageBox.Show("ID excluido com sucesso!");
                            atualizaGrid();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Voce deve selecionar uma linha para continuar", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Houve um erro:" + er.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizaGrid_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }
    }
}
