using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceCalc_PRO
{
    public partial class frmMain : Form
    {
        private NotifyIcon notifyIcon;
        private ToolStrip tool;

        private bool toolStripMinimized = false;
        private int toolStripOriginalWidth;

        public frmMain()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            notifyIcon.Text = "SpaceCalc - PRO";
            notifyIcon.DoubleClick += new EventHandler(NotifyIcon_DoubleClick);
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add("Abrir", NotifyIcon_Open);
            contextMenu.MenuItems.Add("Fechar", NotifyIcon_Close);
            notifyIcon.ContextMenu = contextMenu;

            login frm = new login();
            frm.ShowDialog();
            if (frm.logado)
            {
                InitializeComponent();
                toolStripOriginalWidth = toolStrip1.Width;
                txtNomeUsuario.Text = $"{session.username} - {session.departmentDESC}";
                if(session.departmentID != "1")
                {
                    toolAbaAdministracao.Visible = false;
                }
            }
            else
            {
                Environment.Exit(0);
            }

            lblVersion.Text += Version.versao;
        }

        //Methods
        #region

        //Abrir form
        public void ajusteForm(Form frm)
        {
            // Crie uma nova aba com o nome do formulário
            TabPage newTabPage = new TabPage(frm.Text);

            // Configure o formulário para ser exibido dentro da aba
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            // Adicione o formulário à nova aba e a aba ao TabControl
            newTabPage.Controls.Add(frm);
            tabControl1.TabPages.Add(newTabPage);

            // Exiba o formulário e, opcionalmente, selecione a nova aba
            frm.Show();
            tabControl1.SelectedTab = newTabPage; // opcional: selecionar a nova aba adicionada
        }

        #endregion

        //LoadForm
        #region


        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void NotifyIcon_Open(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void NotifyIcon_Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
            }
        }

        #endregion

        private void mudarTool(ToolStrip aba)
        {
            if (tool != null && tool != aba)
            {
                tool.Visible = false;
                aba.Visible = true;
                tool = aba;
            }
            else if (tool == null)
            {
                tool = aba;
                aba.Visible = true;
            }
            else
            {
                
            }
            
        }

        private void toolCusto_Click(object sender, EventArgs e)
        {
            mudarTool(toolStrip2);
        }

        private void btnCalculadora_Click_1(object sender, EventArgs e)
        {
            frmVisaoCalculadora frm = new frmVisaoCalculadora();
            ajusteForm(frm);
        }

        private void btnCustos_Click_1(object sender, EventArgs e)
        {
            frmVisaoCustos frm = new frmVisaoCustos();
            ajusteForm(frm);
        }

        private void minimizeToolStripButton_Click(object sender, EventArgs e)
        {
            if (!toolStripMinimized)
            {
                toolStrip1.Width = 50;
                toolStripMinimized = true;
                btnMinimizarExpandir.Width = toolStrip1.Width;
                foreach (ToolStripItem item in toolStrip1.Items)
                {
                    if (item is ToolStripButton)
                    {
                        ((ToolStripButton)item).DisplayStyle = ToolStripItemDisplayStyle.Image;
                    }
                }
                toolStripLabel1.Text = "SC";
                btnMinimizarExpandir.Image = Properties.Resources.next_16x16;
            }
            else
            {
                toolStrip1.Width = toolStripOriginalWidth;
                toolStripMinimized = false;
                btnMinimizarExpandir.Width = toolStrip1.Width;
                foreach (ToolStripItem item in toolStrip1.Items)
                {
                    if (item is ToolStripButton)
                    {
                        ((ToolStripButton)item).DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                    }
                }
                toolStripLabel1.Text = "SpaceCalc - PRO";
                btnMinimizarExpandir.Image = Properties.Resources.prev_16x16;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"Versão atual: {Version.versao}", "Mensagem do Sistema",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            frmAppConfiguration frm = new frmAppConfiguration();
            frm.Show();
        }

        private void toolAbaCadastros_Click(object sender, EventArgs e)
        {
            mudarTool(toolStrip5);
        }

        private async void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> filtros = new Dictionary<string, string>();
            filtros.Add("IDUSUARIO", session.idusuario);
            filtros.Add("IDBOTAO", "1");
            string busca = await MongoDB.DTWhereAsString("ZBOTAOSEGURANCACOMPL", filtros, "_id");
            if (!String.IsNullOrWhiteSpace(busca) || session.departmentID == "1")
            {
                frmVisaoProduto frm = new frmVisaoProduto();
                ajusteForm(frm);
            }
            else
            {
                MessageBox.Show($"Permissão de botão negada. \n\nContate o suporte do software para permitir o uso do botão.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtualizarSoftware_Click(object sender, EventArgs e)
        {
            // ÁREA DE UPDATE (INDISPONIBILIDADE COM VERSÃO DE DESENVOLVIMENTO)

            // DISPONÍVEL À ALTERAÇÕES

            /*

            if (IsInternetAvailable())
                {
                    try
                    {
                        WebClient webClient = new WebClient();
                        if (!webClient.DownloadString("").Contains(Version.versao))
                        {
                            if (MessageBox.Show("Você deseja atualizar o sistema?", "Pergunta do sistema?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                }
                else
                {
                    MessageBox.Show("Sem conexão com a internet. Verifique sua conexão e tente novamente.", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            */
        }

        private bool IsInternetAvailable()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.google.com"))
                    return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnCadastroBotaoSeguranca_Click(object sender, EventArgs e)
        {
            frmVisaoBotaoSeguranca frm = new frmVisaoBotaoSeguranca();
            ajusteForm(frm);
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            frmVisaoUsuario frm = new frmVisaoUsuario();
            ajusteForm(frm);
        }

        private void toolAbaAdministracao_Click(object sender, EventArgs e)
        {
            mudarTool(toolStrip6);
        }

        private void btnPermitirUsuario_Click(object sender, EventArgs e)
        {
            frmVisaoBotaoSegurancaUsuario frm = new frmVisaoBotaoSegurancaUsuario();
            ajusteForm(frm);
        }

        private void btnCadastroSetor_Click(object sender, EventArgs e)
        {
            frmVisaoSetor frm = new frmVisaoSetor();
            ajusteForm(frm);
        }

        private async void btnPedido_Click(object sender, EventArgs e)
        {


            Dictionary<string, string> filtros = new Dictionary<string, string>();
            filtros.Add("IDUSUARIO", session.idusuario);
            filtros.Add("IDBOTAO", "2");
            string busca = await MongoDB.DTWhereAsString("ZBOTAOSEGURANCACOMPL", filtros, "_id");
            if (!String.IsNullOrWhiteSpace(busca) || session.departmentID == "1")
            {
                frmVisaoPedido frm = new frmVisaoPedido();
                ajusteForm(frm);
            }
            else
            {
                MessageBox.Show($"Permissão de botão negada. \n\nContate o suporte do software para permitir o uso do botão.", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void toolAbaPedidosOrdens_Click(object sender, EventArgs e)
        {
            mudarTool(toolStrip3);
        }
    }
}
