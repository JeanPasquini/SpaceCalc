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
    public partial class frmSelecionaProcesso : Form
    {
        public List<string> OpcoesSelecionadas { get; set; } = new List<string>();
        public List<string> OpcoesCustos { get; set; } = new List<string>();
        public List<string> OpcoesCod { get; set; } = new List<string>();

        public frmSelecionaProcesso()
        {
            InitializeComponent();

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

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CODPRO", typeof(int));
            dataTable.Columns.Add("Processo", typeof(string));
            dataTable.Columns.Add("Custo p/Hr", typeof(string));

            dataTable.Rows.Add(0, "Plasma CNC");
            dataTable.Rows.Add(1, "Laser CNC");
            dataTable.Rows.Add(2, "Corte Guilhotina CNC");
            dataTable.Rows.Add(3, "Corte Serra");
            dataTable.Rows.Add(4, "Dobramento");
            dataTable.Rows.Add(5, "Puncionadeira");
            dataTable.Rows.Add(6, "Mão de obra");

            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
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
                        OpcoesSelecionadas.Add(linha);
                        OpcoesCod.Add(cod);
                        OpcoesCustos.Add(custo);
                    }
                }
            }

            this.Close();
        }
    }
}
