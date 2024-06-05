
namespace SpaceCalc_PRO
{
    partial class frmVisaoCustos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemoverProcesso = new System.Windows.Forms.Button();
            this.btnAdicionarProcesso = new System.Windows.Forms.Button();
            this.lblCustos = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.ComboBox();
            this.btnLimparHistorico = new System.Windows.Forms.Button();
            this.btnRemoverAnterior = new System.Windows.Forms.Button();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Processos Fabricação";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnRemoverProcesso
            // 
            this.btnRemoverProcesso.Image = global::SpaceCalc_PRO.Properties.Resources.deletelist2_16x16;
            this.btnRemoverProcesso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverProcesso.Location = new System.Drawing.Point(146, 19);
            this.btnRemoverProcesso.Name = "btnRemoverProcesso";
            this.btnRemoverProcesso.Size = new System.Drawing.Size(134, 23);
            this.btnRemoverProcesso.TabIndex = 2;
            this.btnRemoverProcesso.Text = "Remover Processo";
            this.btnRemoverProcesso.UseVisualStyleBackColor = true;
            this.btnRemoverProcesso.Click += new System.EventHandler(this.btnRemoverProcesso_Click);
            // 
            // btnAdicionarProcesso
            // 
            this.btnAdicionarProcesso.Image = global::SpaceCalc_PRO.Properties.Resources.addfile_16x16;
            this.btnAdicionarProcesso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarProcesso.Location = new System.Drawing.Point(6, 19);
            this.btnAdicionarProcesso.Name = "btnAdicionarProcesso";
            this.btnAdicionarProcesso.Size = new System.Drawing.Size(134, 23);
            this.btnAdicionarProcesso.TabIndex = 1;
            this.btnAdicionarProcesso.Text = "Adicionar Processo";
            this.btnAdicionarProcesso.UseVisualStyleBackColor = true;
            this.btnAdicionarProcesso.Click += new System.EventHandler(this.btnAdicionarProcesso_Click);
            // 
            // lblCustos
            // 
            this.lblCustos.AutoSize = true;
            this.lblCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustos.Location = new System.Drawing.Point(6, 29);
            this.lblCustos.Name = "lblCustos";
            this.lblCustos.Size = new System.Drawing.Size(24, 25);
            this.lblCustos.TabIndex = 1;
            this.lblCustos.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCustos);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(12, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 239);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Histórico";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.PrecoTotal});
            this.dataGridView2.Location = new System.Drawing.Point(6, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(479, 214);
            this.dataGridView2.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // PrecoTotal
            // 
            this.PrecoTotal.HeaderText = "Preço Total";
            this.PrecoTotal.Name = "PrecoTotal";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNome);
            this.groupBox4.Controls.Add(this.btnLimparHistorico);
            this.groupBox4.Controls.Add(this.btnRemoverAnterior);
            this.groupBox4.Controls.Add(this.btnNovoItem);
            this.groupBox4.Location = new System.Drawing.Point(509, 285);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 239);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Botões";
            // 
            // txtNome
            // 
            this.txtNome.FormattingEnabled = true;
            this.txtNome.Items.AddRange(new object[] {
            "Ferro Redondo",
            "Ferro Chato",
            "Cantoneira",
            "Tubo Ret/Quad",
            "Tubo Redondo"});
            this.txtNome.Location = new System.Drawing.Point(6, 58);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(145, 21);
            this.txtNome.TabIndex = 2;
            // 
            // btnLimparHistorico
            // 
            this.btnLimparHistorico.Image = global::SpaceCalc_PRO.Properties.Resources.cleartablestyle_16x16;
            this.btnLimparHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparHistorico.Location = new System.Drawing.Point(157, 29);
            this.btnLimparHistorico.Name = "btnLimparHistorico";
            this.btnLimparHistorico.Size = new System.Drawing.Size(123, 23);
            this.btnLimparHistorico.TabIndex = 6;
            this.btnLimparHistorico.Text = "Limpar";
            this.btnLimparHistorico.UseVisualStyleBackColor = true;
            this.btnLimparHistorico.Click += new System.EventHandler(this.btnLimparHistorico_Click);
            // 
            // btnRemoverAnterior
            // 
            this.btnRemoverAnterior.Image = global::SpaceCalc_PRO.Properties.Resources.reset_16x16;
            this.btnRemoverAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverAnterior.Location = new System.Drawing.Point(6, 29);
            this.btnRemoverAnterior.Name = "btnRemoverAnterior";
            this.btnRemoverAnterior.Size = new System.Drawing.Size(145, 23);
            this.btnRemoverAnterior.TabIndex = 5;
            this.btnRemoverAnterior.Text = "Remover anterior";
            this.btnRemoverAnterior.UseVisualStyleBackColor = true;
            this.btnRemoverAnterior.Click += new System.EventHandler(this.btnRemoverAnterior_Click);
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Image = global::SpaceCalc_PRO.Properties.Resources.add_16x16;
            this.btnNovoItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoItem.Location = new System.Drawing.Point(157, 56);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(122, 23);
            this.btnNovoItem.TabIndex = 4;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRemoverProcesso);
            this.groupBox5.Controls.Add(this.btnAdicionarProcesso);
            this.groupBox5.Location = new System.Drawing.Point(509, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 175);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Botões";
            // 
            // frmVisaoCustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVisaoCustos";
            this.Text = "Custos";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoverProcesso;
        private System.Windows.Forms.Button btnAdicionarProcesso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCustos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox txtNome;
        private System.Windows.Forms.Button btnLimparHistorico;
        private System.Windows.Forms.Button btnRemoverAnterior;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoTotal;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}