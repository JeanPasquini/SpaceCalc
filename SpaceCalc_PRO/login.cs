using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceCalc_PRO
{
    public partial class login : Form
    {
        public bool logado { get; set; }


        public login()
        {
            InitializeComponent();
            txtVersao.Text = Version.versao;

            // ÁREA DE UPDATE (INDISPONIBILIDADE COM VERSÃO DE DESENVOLVIMENTO)

            // DISPONÍVEL À ALTERAÇÕES

            /*
               WebClient webClient = new WebClient();


               try
               {
                   if (!webClient.DownloadString("").Contains(Version.versao))
                   {
                       if (MessageBox.Show("Existe uma atualização nova, deseja atualizar seu software?", "Atualização do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                           using (var client = new WebClient())
                           {
                               Process.Start("Updater.exe");
                               this.Close();
                           }
                   }
               }
               catch
               {

               }
           */
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            logar();
        }

        private async void logar()
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            Dictionary<string, string> filtros = new Dictionary<string, string>();
            filtros.Add("USUARIO", usuario);
            filtros.Add("SENHA", senha);

            Dictionary<string, string> filtroDesc = new Dictionary<string, string>();
            filtroDesc.Add("CODIGOSETOR", await MongoDB.DTWhereAsString("ZUSUARIO", filtros, "IDSETOR"));

            string busca = await MongoDB.DTWhereAsString("ZUSUARIO", filtros, "USUARIO");
            if (!String.IsNullOrEmpty(busca))
            {
                logado = true;
                session.idusuario = await MongoDB.DTWhereAsString("ZUSUARIO", filtros, "_id");
                session.account = await MongoDB.DTWhereAsString("ZUSUARIO", filtros, "USUARIO");
                session.username = await MongoDB.DTWhereAsString("ZUSUARIO", filtros, "NOMECOMPLETO") ;
                session.password = await MongoDB.DTWhereAsString("ZUSUARIO", filtros, "SENHA") ;
                session.departmentID = await MongoDB.DTWhereAsString("ZUSUARIO", filtros, "IDSETOR");
                session.departmentDESC = await MongoDB.DTWhereAsString("ZSETOR", filtroDesc, "NOMESETOR");

                this.Close();
            }
            else
            {
                MessageBox.Show($"Usuário não registrado! \n\nConsulte um desenvolvedor para cadastrar no sistema de SpaceCalc - PRO {Version.versao}", "Messagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            logado = false;
            this.Close();
        }

        private void btnLogar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                logar();
            }
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            frmAppConfiguration frm = new frmAppConfiguration();
            frm.ShowDialog();
        }
    }
}
