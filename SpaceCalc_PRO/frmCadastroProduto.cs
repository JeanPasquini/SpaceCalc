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
    public partial class frmCadastroProduto : Form
    {
        private string id;
        private bool editar;

        public frmCadastroProduto(string id, bool editar)
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
                var existingDocument = await MongoDB.selectID("ZPRODUTO", id);

                if (existingDocument != null)
                {
                    existingDocument["CODIGO"] = txtCodigo.Text;
                    existingDocument["NOMEFANTASIA"]  = txtNomeFantasia.Text;
                    existingDocument["PESO"] = txtPeso.Text;
                    existingDocument["LARGURA"] = txtLargura.Text;
                    existingDocument["EXPESSURA"] = txtExpessura.Text;
                    existingDocument["COMPRIMENTO"] = txtComprimento.Text;

                    bool updateResult = await MongoDB.updateDT("ZPRODUTO", id, existingDocument);

                    if (updateResult)
                    {
                        Console.WriteLine("Documento atualizado com sucesso na coleção 'ZPRODUTO'!");
                    }
                    else
                    {
                        Console.WriteLine("Erro ao atualizar o documento na coleção 'ZPRODUTO'.");
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
                    if (!String.IsNullOrEmpty(txtCodigo.Text) && !String.IsNullOrEmpty(txtComprimento.Text) && !String.IsNullOrEmpty(txtExpessura.Text) &&
                        !String.IsNullOrEmpty(txtLargura.Text) && !String.IsNullOrEmpty(txtNomeFantasia.Text) && !String.IsNullOrEmpty(txtPeso.Text))
                    {

                        var document = new BsonDocument
                        {
                            { "CODIGO", txtCodigo.Text },
                            { "NOMEFANTASIA", txtNomeFantasia.Text },
                            { "PESO", txtPeso.Text },
                            { "LARGURA", txtLargura.Text },
                            { "EXPESSURA", txtExpessura.Text },
                            { "COMPRIMENTO", txtComprimento.Text }
                        };

                        await MongoDB.insertDT("ZPRODUTO", document);

                        Console.WriteLine("Documento inserido com sucesso na coleção 'ZPRODUTO'!");
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
            string collectionName = "ZPRODUTO";

            var document = await MongoDB.selectID(collectionName, id);

            if (document != null)
            {
                string ID = document.Contains("_id") ? document["_id"].ToString() : string.Empty;
                string CODIGO = document.Contains("CODIGO") ? document["CODIGO"].AsString : string.Empty;
                string NOMEFANTASIA = document.Contains("NOMEFANTASIA") ? document["NOMEFANTASIA"].AsString : string.Empty;
                string PESO = document.Contains("PESO") ? document["PESO"].AsString : string.Empty;
                string LARGURA = document.Contains("LARGURA") ? document["LARGURA"].AsString : string.Empty;
                string EXPESSURA = document.Contains("EXPESSURA") ? document["EXPESSURA"].AsString : string.Empty;
                string COMPRIMENTO = document.Contains("COMPRIMENTO") ? document["COMPRIMENTO"].AsString : string.Empty;

                txtID.Text = ID;
                txtCodigo.Text = CODIGO;
                txtNomeFantasia.Text = NOMEFANTASIA;
                txtPeso.Text = PESO;
                txtLargura.Text = LARGURA;
                txtExpessura.Text = EXPESSURA;  
                txtComprimento.Text = COMPRIMENTO; 
            }
        }
    }
}
