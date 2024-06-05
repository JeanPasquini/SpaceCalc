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
    public partial class frmCadastroSetor : Form
    {

        public frmCadastroSetor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (!String.IsNullOrEmpty(txtCodigoBotao.Text) && !String.IsNullOrEmpty(txtNomeBotao.Text) && !String.IsNullOrEmpty(txtDescricaoBotao.Text))
                    {

                        var document = new BsonDocument
                        {
                            { "CODIGOSETOR", txtCodigoBotao.Text },
                            { "NOMESETOR", txtNomeBotao.Text },
                            { "DESCRICAOBOTAO", txtDescricaoBotao.Text }
                        };

                        await MongoDB.insertDT("ZSETOR", document);

                        Console.WriteLine("Documento inserido com sucesso na coleção 'ZSETOR'!");
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
}