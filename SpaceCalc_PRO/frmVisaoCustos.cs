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
    public partial class frmVisaoCustos : Form
    {
        List<string> opcoesSelecionadas;
        List<string> opcoesCusto;
        List<string> opcoesCod;
        int custoTotal;
        DataTable dataTable = new DataTable();

        public frmVisaoCustos()
        {
            InitializeComponent();
            dataTable.Columns.Add("CODPRO", typeof(string));
            dataTable.Columns.Add("Processo", typeof(string));
            dataTable.Columns.Add("Custo p/Hr", typeof(string));
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "CheckBoxColumn",
                HeaderText = "Selecionar",
                FalseValue = false,
                TrueValue = true,
                IndeterminateValue = null,
                DataPropertyName = "IsSelected"
            };
            dataGridView1.Columns.Add(checkBoxColumn);
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void atualizaGrid()
        {
            custoTotal = 0;
            dataTable.Rows.Clear();

            int f = 0;
            foreach (string opcao in opcoesSelecionadas)
            {
                dataTable.Rows.Add(opcoesCod[f], opcao, "R$"+opcoesCusto[f]);
                if (opcoesCusto[f] == null || string.IsNullOrEmpty(opcoesCusto[f]))
                {
                    opcoesCusto[f] = "0";
                }
                else
                {
                    custoTotal += int.Parse(opcoesCusto[f]);
                }
                f++;
            }

            lblCustos.Text = "R$ " + custoTotal.ToString();
        }

        private void btnAdicionarProcesso_Click(object sender, EventArgs e)
        {
            frmSelecionaProcesso frm = new frmSelecionaProcesso();
            frm.ShowDialog();
            opcoesSelecionadas = frm.OpcoesSelecionadas;
            opcoesCusto = frm.OpcoesCustos;
            opcoesCod = frm.OpcoesCod;
            atualizaGrid();
        }

        private void btnRemoverProcesso_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["CheckBoxColumn"] as DataGridViewCheckBoxCell;
                bool isChecked = (checkBoxCell.Value != null && (bool)checkBoxCell.Value);

                if (isChecked)
                {
                    string valorColuna1 = row.Cells["CODPRO"].Value?.ToString();
                    string valorColuna2 = row.Cells["Processo"].Value?.ToString();
                    string valorColuna3 = row.Cells["Custo p/Hr"].Value?.ToString();

                    if (!string.IsNullOrEmpty(valorColuna1) && !string.IsNullOrEmpty(valorColuna2))
                    {
                        string linha = valorColuna2;
                        string custo = valorColuna3;
                        string cod = valorColuna1;
                        opcoesSelecionadas.Remove(linha);
                        opcoesCod.Remove(cod);
                        opcoesCusto.Remove(custo);
                    }
                }
            }
            atualizaGrid();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txtNome.Text, lblCustos.Text);
        }

        private void btnLimparHistorico_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
        }

        private void btnRemoverAnterior_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                int lastIndex = dataGridView2.Rows.Count;
                dataGridView2.Rows.RemoveAt(lastIndex);
            }
        }
    }
}
