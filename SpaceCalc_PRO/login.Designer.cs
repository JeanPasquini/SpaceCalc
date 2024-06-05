
namespace SpaceCalc_PRO
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogar = new Krypton.Toolkit.KryptonButton();
            this.btnCancelar = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtUsuario = new Krypton.Toolkit.KryptonTextBox();
            this.txtSenha = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonToolStrip1 = new Krypton.Toolkit.KryptonToolStrip();
            this.btnConfiguracoes = new System.Windows.Forms.ToolStripButton();
            this.txtVersao = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(174, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(174, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(319, 144);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.btnLogar.Size = new System.Drawing.Size(68, 25);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Values.Text = "Entrar";
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(245, 144);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.btnCancelar.Size = new System.Drawing.Size(68, 25);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Values.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(218, 14);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.kryptonLabel1.Size = new System.Drawing.Size(135, 34);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 13;
            this.kryptonLabel1.Values.Image = global::SpaceCalc_PRO.Properties.Resources.cube_32x32;
            this.kryptonLabel1.Values.Text = "SpaceCalc - PRO";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoCompleteCustomSource.AddRange(new string[] {
            "jean"});
            this.txtUsuario.Location = new System.Drawing.Point(177, 70);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black;
            this.txtUsuario.Size = new System.Drawing.Size(210, 25);
            this.txtUsuario.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsuario.StateCommon.Border.Rounding = 3F;
            this.txtUsuario.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUsuario.StateNormal.Border.Width = 1;
            this.txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(177, 111);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007Black;
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(210, 25);
            this.txtSenha.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSenha.StateCommon.Border.Rounding = 3F;
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLogar_KeyPress);
            // 
            // kryptonToolStrip1
            // 
            this.kryptonToolStrip1.BackColor = System.Drawing.Color.DarkMagenta;
            this.kryptonToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonToolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kryptonToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.kryptonToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConfiguracoes,
            this.txtVersao});
            this.kryptonToolStrip1.Location = new System.Drawing.Point(0, 184);
            this.kryptonToolStrip1.Name = "kryptonToolStrip1";
            this.kryptonToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.kryptonToolStrip1.Size = new System.Drawing.Size(402, 25);
            this.kryptonToolStrip1.TabIndex = 14;
            this.kryptonToolStrip1.Text = "kryptonToolStrip1";
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnConfiguracoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConfiguracoes.Image = global::SpaceCalc_PRO.Properties.Resources.gears;
            this.btnConfiguracoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(23, 22);
            this.btnConfiguracoes.Text = "toolStripButton1";
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // txtVersao
            // 
            this.txtVersao.BackColor = System.Drawing.Color.Transparent;
            this.txtVersao.ForeColor = System.Drawing.SystemColors.Control;
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(0, 22);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SpaceCalc_PRO.Properties.Resources.hexagonos_03;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(42, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 324);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 209);
            this.Controls.Add(this.kryptonToolStrip1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.kryptonToolStrip1.ResumeLayout(false);
            this.kryptonToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton btnLogar;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtUsuario;
        private Krypton.Toolkit.KryptonTextBox txtSenha;
        private System.Windows.Forms.ToolStripButton btnConfiguracoes;
        private Krypton.Toolkit.KryptonToolStrip kryptonToolStrip1;
        private System.Windows.Forms.ToolStripLabel txtVersao;
    }
}