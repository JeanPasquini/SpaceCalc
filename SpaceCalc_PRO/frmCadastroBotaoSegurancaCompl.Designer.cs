namespace SpaceCalc_PRO
{
    partial class frmCadastroBotaoSegurancaCompl
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
            this.txtNomeBotao = new Krypton.Toolkit.KryptonTextBox();
            this.txtCodigo = new Krypton.Toolkit.KryptonTextBox();
            this.btnSelecionarBotao = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(391, 71);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 25);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Values.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(295, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Values.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(130, 16);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(104, 20);
            this.kryptonLabel3.TabIndex = 11;
            this.kryptonLabel3.Values.Text = "Descrição do botão";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 16);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(33, 20);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "COD";
            // 
            // txtNomeBotao
            // 
            this.txtNomeBotao.Enabled = false;
            this.txtNomeBotao.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.txtNomeBotao.Location = new System.Drawing.Point(130, 42);
            this.txtNomeBotao.MaximumSize = new System.Drawing.Size(351, 23);
            this.txtNomeBotao.Name = "txtNomeBotao";
            this.txtNomeBotao.Size = new System.Drawing.Size(351, 21);
            this.txtNomeBotao.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.txtCodigo.Location = new System.Drawing.Point(12, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(76, 21);
            this.txtCodigo.TabIndex = 12;
            // 
            // btnSelecionarBotao
            // 
            this.btnSelecionarBotao.Location = new System.Drawing.Point(94, 42);
            this.btnSelecionarBotao.Name = "btnSelecionarBotao";
            this.btnSelecionarBotao.Size = new System.Drawing.Size(30, 22);
            this.btnSelecionarBotao.TabIndex = 13;
            this.btnSelecionarBotao.Values.Text = "...";
            this.btnSelecionarBotao.Click += new System.EventHandler(this.btnSelecionarBotao_Click);
            // 
            // frmCadastroBotaoSegurancaCompl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(490, 108);
            this.Controls.Add(this.btnSelecionarBotao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.txtNomeBotao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastroBotaoSegurancaCompl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Botao para Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnSalvar;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtNomeBotao;
        private Krypton.Toolkit.KryptonTextBox txtCodigo;
        private Krypton.Toolkit.KryptonButton btnSelecionarBotao;
    }
}