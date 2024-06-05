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
    public partial class frmCadastroBotaoSegurancaCompl : Form
    {
        private string id;
        private bool editar;

        public frmCadastroBotaoSegurancaCompl(string id)
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
                    if (!String.IsNullOrEmpty(txtCodigo.Text) && !String.IsNullOrEmpty(txtNomeBotao.Text) && !String.IsNullOrEmpty(txtNomeBotao.Text))
                    {

                        var document = new BsonDocument
                        {
                            { "IDUSUARIO", id},
                            { "IDBOTAO", txtCodigo.Text },
                            { "DESCRICAOBOTAO", txtNomeBotao.Text }
                        };

                        await MongoDB.insertDT("ZBOTAOSEGURANCACOMPL", document);

                        Console.WriteLine("Documento inserido com sucesso na coleção 'ZBOTAOSEGURANCACOMPL'!");
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
            frmSelecionaBotaoSegurancaCompl frm = new frmSelecionaBotaoSegurancaCompl();
            frm.ShowDialog();

            txtCodigo.Text = frm.id;
            txtNomeBotao.Text = frm.descricao;
        }
    }
}