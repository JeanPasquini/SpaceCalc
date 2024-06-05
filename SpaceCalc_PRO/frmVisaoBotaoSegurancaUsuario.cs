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
    public partial class frmVisaoBotaoSegurancaUsuario : Form
    {
        public frmVisaoBotaoSegurancaUsuario()
        {
            InitializeComponent();
        }

        private async void atualizaGrid()
        {
            try
            {
                showWaitForm.Open();
                DataTable table = await MongoDB.DT("ZUSUARIO");

                if (table != null)
                {
                    kryptonDataGridView1.DataSource = table;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (kryptonDataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = kryptonDataGridView1.SelectedRows[0];

                string idUSUARIO = selectedRow.Cells[0].Value.ToString();

                frmBotaoSegurancaUsuarioCompl frm = new frmBotaoSegurancaUsuarioCompl(idUSUARIO);
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
