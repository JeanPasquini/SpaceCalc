namespace SpaceCalc_PRO
{
    partial class frmCadastroPedido
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
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox2 = new Krypton.Toolkit.KryptonGroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtIDPedido = new Krypton.Toolkit.KryptonTextBox();
            this.txtPedidoCodigo = new Krypton.Toolkit.KryptonTextBox();
            this.txtPedidoDescricao = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonGroupBox3 = new Krypton.Toolkit.KryptonGroupBox();
            this.txtNome = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtObservacaoPedido = new Krypton.Toolkit.KryptonTextBox();
            this.txtIDNome = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.btnAdicionarProduto = new System.Windows.Forms.ToolStripButton();
            this.btnRemoverProduto = new System.Windows.Forms.ToolStripButton();
            this.btnAtualizaGrid = new System.Windows.Forms.ToolStripButton();
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(764, 490);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 25);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Values.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(668, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Values.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtObservacaoPedido);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtPedidoDescricao);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtPedidoCodigo);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtIDPedido);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(842, 172);
            this.kryptonGroupBox1.TabIndex = 3;
            this.kryptonGroupBox1.Values.Heading = "Dados do pedido";
            this.kryptonGroupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroupBox1_Paint);
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(12, 285);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonDataGridView1);
            this.kryptonGroupBox2.Panel.Controls.Add(this.toolStrip1);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(842, 199);
            this.kryptonGroupBox2.TabIndex = 4;
            this.kryptonGroupBox2.Values.Heading = "Produtos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdicionarProduto,
            this.btnRemoverProduto,
            this.btnAtualizaGrid});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(838, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtIDPedido
            // 
            this.txtIDPedido.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.txtIDPedido.Location = new System.Drawing.Point(3, 31);
            this.txtIDPedido.Name = "txtIDPedido";
            this.txtIDPedido.Size = new System.Drawing.Size(188, 22);
            this.txtIDPedido.TabIndex = 0;
            // 
            // txtPedidoCodigo
            // 
            this.txtPedidoCodigo.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelClient;
            this.txtPedidoCodigo.Location = new System.Drawing.Point(197, 31);
            this.txtPedidoCodigo.Name = "txtPedidoCodigo";
            this.txtPedidoCodigo.Size = new System.Drawing.Size(98, 22);
            this.txtPedidoCodigo.TabIndex = 2;
            // 
            // txtPedidoDescricao
            // 
            this.txtPedidoDescricao.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelClient;
            this.txtPedidoDescricao.Location = new System.Drawing.Point(301, 31);
            this.txtPedidoDescricao.Name = "txtPedidoDescricao";
            this.txtPedidoDescricao.Size = new System.Drawing.Size(534, 22);
            this.txtPedidoDescricao.TabIndex = 3;
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Location = new System.Drawing.Point(12, 190);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroupBox3.Panel.Controls.Add(this.txtIDNome);
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox3.Panel.Controls.Add(this.txtNome);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(842, 89);
            this.kryptonGroupBox3.TabIndex = 5;
            this.kryptonGroupBox3.Values.Heading = "Dados de criação";
            // 
            // txtNome
            // 
            this.txtNome.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.txtNome.Location = new System.Drawing.Point(197, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(638, 22);
            this.txtNome.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(22, 22);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "ID";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(197, 3);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(50, 22);
            this.kryptonLabel2.TabIndex = 5;
            this.kryptonLabel2.Values.Text = "Código";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(301, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(123, 22);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "Descrição do Pedido";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(22, 22);
            this.kryptonLabel4.TabIndex = 7;
            this.kryptonLabel4.Values.Text = "ID";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(3, 59);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(75, 22);
            this.kryptonLabel5.TabIndex = 8;
            this.kryptonLabel5.Values.Text = "Observação";
            // 
            // txtObservacaoPedido
            // 
            this.txtObservacaoPedido.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelClient;
            this.txtObservacaoPedido.Location = new System.Drawing.Point(3, 87);
            this.txtObservacaoPedido.Multiline = true;
            this.txtObservacaoPedido.Name = "txtObservacaoPedido";
            this.txtObservacaoPedido.Size = new System.Drawing.Size(832, 58);
            this.txtObservacaoPedido.TabIndex = 9;
            // 
            // txtIDNome
            // 
            this.txtIDNome.InputControlStyle = Krypton.Toolkit.InputControlStyle.PanelAlternate;
            this.txtIDNome.Location = new System.Drawing.Point(3, 31);
            this.txtIDNome.Name = "txtIDNome";
            this.txtIDNome.Size = new System.Drawing.Size(188, 22);
            this.txtIDNome.TabIndex = 7;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(197, 3);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(44, 22);
            this.kryptonLabel6.TabIndex = 10;
            this.kryptonLabel6.Values.Text = "Nome";
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Image = global::SpaceCalc_PRO.Properties.Resources.add;
            this.btnAdicionarProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(124, 22);
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Image = global::SpaceCalc_PRO.Properties.Resources.cancel_16x16;
            this.btnRemoverProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(120, 22);
            this.btnRemoverProduto.Text = "Remover Produto";
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnAtualizaGrid
            // 
            this.btnAtualizaGrid.Image = global::SpaceCalc_PRO.Properties.Resources.rotation16;
            this.btnAtualizaGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtualizaGrid.Name = "btnAtualizaGrid";
            this.btnAtualizaGrid.Size = new System.Drawing.Size(98, 22);
            this.btnAtualizaGrid.Text = "Atualizar Grid";
            this.btnAtualizaGrid.Click += new System.EventHandler(this.btnAtualizaGrid_Click);
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.kryptonDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 25);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(838, 150);
            this.kryptonDataGridView1.TabIndex = 4;
            // 
            // frmCadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(866, 527);
            this.Controls.Add(this.kryptonGroupBox3);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastroPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Pedido";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnSalvar;
        private Krypton.Toolkit.KryptonButton btnCancelar;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private Krypton.Toolkit.KryptonTextBox txtPedidoDescricao;
        private Krypton.Toolkit.KryptonTextBox txtPedidoCodigo;
        private Krypton.Toolkit.KryptonTextBox txtIDPedido;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdicionarProduto;
        private System.Windows.Forms.ToolStripButton btnRemoverProduto;
        private System.Windows.Forms.ToolStripButton btnAtualizaGrid;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private Krypton.Toolkit.KryptonTextBox txtNome;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox txtIDNome;
        private Krypton.Toolkit.KryptonTextBox txtObservacaoPedido;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
    }
}