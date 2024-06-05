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
    public partial class frmCadastroProdutoCompl : Form
    {
        private string id;

        public frmCadastroProdutoCompl(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
                try
                {
                    if (!String.IsNullOrEmpty(txtIDProduto.Text) && !String.IsNullOrEmpty(txtQuantidade.Text))
                    {

                        var document = new BsonDocument
                        {
                            { "IDPEDIDO", id},
                            { "IDPRODUTO", txtIDProduto.Text },
                            { "QUANTIDADE", txtQuantidade.Text }
                        };

                        await MongoDB.insertDT("ZPEDIDOSITEM", document);

                        Console.WriteLine("Documento inserido com sucesso na coleção 'ZPEDIDOSITEM'!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Preencha todos os campos para cadastrar um botão.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Houve um erro:" + er.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btnSelecionarBotao_Click(object sender, EventArgs e)
        {
            frmSelecionaProduto frm = new frmSelecionaProduto();
            frm.ShowDialog();

            txtIDProduto.Text = frm.id;
            txtCodigoProduto.Text = frm.codigo;
            txtNomeProduto.Text = frm.descricao;
        }
    }
}