using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceCalc_PRO
{
    public partial class frmCadastroUsuario : Form
    {
        private string id;
        private bool editar;

        public frmCadastroUsuario(string id, bool editar)
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
                var existingDocument = await MongoDB.selectID("ZUSUARIO", id);

                if (existingDocument != null)
                {
                    existingDocument["USUARIO"] = txtUsuario.Text;
                    existingDocument["SENHA"] = txtSenha.Text;
                    existingDocument["NOMECOMPLETO"] = txtNomeCompleto.Text;
                    existingDocument["EMAIL"] = txtEmail.Text + txtEmailComplemento.Text;
                    existingDocument["IDSETOR"] = txtCodigoSetor.Text;

                    bool updateResult = await MongoDB.updateDT("ZUSUARIO", id, existingDocument);

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
                    if (!String.IsNullOrEmpty(txtUsuario.Text) && !String.IsNullOrEmpty(txtSenha.Text) && !String.IsNullOrEmpty(txtNomeCompleto.Text) && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtEmailComplemento.Text))
                    {

                        var document = new BsonDocument
                        {
                            {"USUARIO" , txtUsuario.Text },
                            {"SENHA" , txtSenha.Text },
                            {"NOMECOMPLETO" , txtNomeCompleto.Text },
                            {"EMAIL" , txtEmail.Text + txtEmailComplemento.Text },
                            {"IDSETOR" , txtCodigoSetor.Text }
                        };

                        await MongoDB.insertDT("ZUSUARIO", document);

                        Console.WriteLine("Documento inserido com sucesso na coleção 'ZUSUARIO'!");
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

        private async void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            string collectionName = "ZUSUARIO";

            var document = await MongoDB.selectID(collectionName, id);

            if (document != null)
            {
                string ID           = document.Contains("_id") ? document["_id"].ToString() : string.Empty;
                string USUARIO      = document.Contains("USUARIO") ? document["USUARIO"].AsString : string.Empty;
                string SENHA        = document.Contains("SENHA") ? document["SENHA"].AsString : string.Empty;
                string NOMECOMPLETO = document.Contains("NOMECOMPLETO") ? document["NOMECOMPLETO"].AsString : string.Empty;
                string EMAIL        = document.Contains("EMAIL") ? document["EMAIL"].AsString : string.Empty;
                string IDSETOR = document.Contains("IDSETOR") ? document["IDSETOR"].AsString : string.Empty;

                Dictionary<string, string> filtros = new Dictionary<string, string>();
                filtros.Add("CODIGOSETOR", IDSETOR);

                string DESCSETOR = await MongoDB.DTWhereAsString("ZSETOR", filtros, "NOMESETOR");

                string[] emailParts = EMAIL.Split('@');
                string emailLocalPart = emailParts.Length > 0 ? emailParts[0] : string.Empty;
                string emailDomainPart = emailParts.Length > 1 ? "@" + emailParts[1] : string.Empty;

                txtID.Text = ID;
                txtCodigoSetor.Text = IDSETOR;
                txtDescricaoSetor.Text = DESCSETOR;
                txtUsuario.Text = USUARIO;
                txtSenha.Text = SENHA;
                txtNomeCompleto.Text = NOMECOMPLETO;

                txtEmail.Text = emailLocalPart;
                txtEmailComplemento.Text = emailDomainPart; 
            }
        }

        private void btnSelecionarSetor_Click(object sender, EventArgs e)
        {
            frmSelecionaSetor frm = new frmSelecionaSetor();
            frm.ShowDialog();
            txtCodigoSetor.Text = frm.id;
            txtDescricaoSetor.Text = frm.descricao;
        }
    }
}