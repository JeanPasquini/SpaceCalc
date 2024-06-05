namespace SpaceCalc_PRO
{
    partial class frmCadastroProdutoCompl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new Krypton.Toolkit.KryptonButton();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.txtIDProduto = new Krypton.Toolkit.KryptonTextBox();
            this.btnSelecionarBotao = new Krypton.Toolkit.KryptonButton();
            this.txtNomeProduto = new Krypton.Toolkit.KryptonTextBox();
            this.txtCodigoProduto = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtQuantidade = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(573, 68);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 25);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Values.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(477, 68);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Values.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(113, 15);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(36, 22);
            this.kryptonLabel3.TabIndex = 11;
            this.kryptonLabel3.Values.Text = "COD";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 16);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(79, 22);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "IDPRODUTO";
            // 
            // txtIDProduto
            // 
            this.txtIDProduto.Enabled = false;
            this.txtIDProduto.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.txtIDProduto.Location = new System.Drawing.Point(12, 41);
            this.txtIDProduto.Name = "txtIDProduto";
            this.txtIDProduto.Size = new System.Drawing.Size(95, 22);
            this.txtIDProduto.TabIndex = 12;
            // 
            // btnSelecionarBotao
            // 
            this.btnSelecionarBotao.Location = new System.Drawing.Point(199, 41);
            this.btnSelecionarBotao.Name = "btnSelecionarBotao";
            this.btnSelecionarBotao.Size = new System.Drawing.Size(30, 22);
            this.btnSelecionarBotao.TabIndex = 13;
            this.btnSelecionarBotao.Values.Text = "...";
            this.btnSelecionarBotao.Click += new System.EventHandler(this.btnSelecionarBotao_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.txtNomeProduto.Location = new System.Drawing.Point(235, 41);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(371, 22);
            this.txtNomeProduto.TabIndex = 14;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Enabled = false;
            this.txtCodigoProduto.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.txtCodigoProduto.Location = new System.Drawing.Point(113, 41);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(80, 22);
            this.txtCodigoProduto.TabIndex = 15;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(235, 15);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(111, 22);
            this.kryptonLabel1.TabIndex = 16;
            this.kryptonLabel1.Values.Text = "Descrição produto";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelClient;
            this.txtQuantidade.Location = new System.Drawing.Point(612, 41);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(51, 22);
            this.txtQuantidade.TabIndex = 17;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(612, 16);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(40, 22);
            this.kryptonLabel4.TabIndex = 18;
            this.kryptonLabel4.Values.Text = "Qtde.";
            // 
            // frmCadastroProdutoCompl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(671, 108);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.btnSelecionarBotao);
            this.Controls.Add(this.txtIDProduto);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastroProdutoCompl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar produto para pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnSalvar;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtIDProduto;
        private Krypton.Toolkit.KryptonButton btnSelecionarBotao;
        private Krypton.Toolkit.KryptonTextBox txtNomeProduto;
        private Krypton.Toolkit.KryptonTextBox txtCodigoProduto;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtQuantidade;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}