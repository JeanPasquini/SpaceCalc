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
    public partial class frmSelecionaSetor : Form
    {
        public string id { get; set; }
        public string descricao { get; set; }

        public frmSelecionaSetor()
        {
            InitializeComponent();
            Load += async (sender, e) => await atualizaGrid(); // Chama atualizaGrid ao carregar o formulário
        }

        private async Task atualizaGrid()
        {
            try
            {
                showWaitForm.Open();
                DataTable table = await MongoDB.DT("ZSETOR");

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

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            seleciona();
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

                id = selectedRow.Cells["CODIGOSETOR"].Value.ToString();
                descricao = selectedRow.Cells["NOMESETOR"].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha para editar.");
            }
            this.Close();
        }
    }
}
