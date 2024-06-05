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
    public partial class frmVisaoPedido : Form
    {
        public frmVisaoPedido()
        {
            InitializeComponent();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            frmCadastroPedido frm = new frmCadastroPedido(null, false);
            frm.ShowDialog();
            atualizaGrid();
        }
        private async void atualizaGrid()
        {
            try
            {
                showWaitForm.Open();
                DataTable table = await MongoDB.DT("ZPEDIDOS");
                DataTable table2 = await MongoDB.DT("ZUSUARIO");

                DataTable table3 = await MongoDB.InnerJoin(table, table2, "IDUSUARIODECRIACAO", "_id");
                string[] filterString = {"_id", "CODIGOPEDIDO", "NOMEPEDIDO", "OBSERVACAOPEDIDO", "USUARIO"};

                DataTable filter = await MongoDB.FilterColumns(table3, filterString);

                if (filter != null)
                {
                    kryptonDataGridView1.DataSource = filter;
                }
                else
                {
                    Console.WriteLine("Erro ao preencher o DataGridView.");
                }
                showWaitForm.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Houve um erro:" + er.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizaGrid_Click(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void frmVisaoProduto_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private async void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonDataGridView1.SelectedRows.Count > 0)
                {
                    var selectedRow = kryptonDataGridView1.SelectedRows[0];

                    string id = selectedRow.Cells[0].Value.ToString();

                    DialogResult result = MessageBox.Show($@"Deseja exclui o Pedido de ID: {id}?", "Pergunta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        bool deleteResult = await MongoDB.deleteDT("ZPEDIDOS", id);

                        if (deleteResult)
                        {
                            MessageBox.Show("ID excluido com sucesso!");
                            atualizaGrid();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Voce deve selecionar uma linha para continuar", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Houve um erro:" + er.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            seleciona();
        }

        private async void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                showWaitForm.Open();
                DataTable table = await MongoDB.DT("ZPEDIDOSITEM");

                if (table != null)
                {
                    //kryptonDataGridView2.DataSource = table;
                }
                else
                {
                    Console.WriteLine("Erro ao preencher o DataGridView.");
                }
                showWaitForm.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Houve um erro:" + er.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kryptonDataGridView1_DoubleClick(object sender, EventArgs e)
        {
            seleciona();
        }

        private void seleciona()
        {
            if (kryptonDataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = kryptonDataGridView1.SelectedRows[0];

                string id = selectedRow.Cells[0].Value.ToString();

                frmCadastroPedido frm = new frmCadastroPedido(id, true);
                frm.ShowDialog();
                atualizaGrid();
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para editar.");
            }
        }
    }
}
