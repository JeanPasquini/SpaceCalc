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
    public partial class frmVisaoCalculadora : Form
    {

        int metrosQuadrados;
        double comprimentoChato = 0;
        double comprimentoRedondo = 0;
        double comprimentoCantoneira = 0;
        
        
        public frmVisaoCalculadora()
        {
            
            InitializeComponent();

            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 1;
        }
        private void KeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Ignora a tecla pressionada se não for um número ou uma vírgula
            }
        }

        private void Calcular()
        {
            TabPage tabPageAtiva = tabControl1.SelectedTab;

            if (tabPageAtiva == f1)
            {
                int Altura = int.Parse(txtAltura.Text);
                int Base = int.Parse(txtBase.Text);
                int Qtde = (int)numericUpDown1.Value;

                metrosQuadrados = Altura * Base * Qtde;
                lbCalculo.Text = metrosQuadrados.ToString();

                dataGridView1.Rows.Add(txtNome.Text, metrosQuadrados, Base, Altura, numericUpDown1.Value);
            }
            else if (tabPageAtiva == f2)
            {
                
                comprimentoChato += double.Parse(txtComprimentoChato.Text) * (int)numericUpDown2.Value;
                double kgChato = double.Parse(txtKGChato.Text);
                int qtdeChato = (int)numericUpDown2.Value;

                int qtdeChatoTotal = (int)Math.Floor(comprimentoChato / 6000);
                double kgChatoTotal = (comprimentoChato / 1000) * double.Parse(txtKGChato.Text);

                lblQtdeChato.Text = qtdeChatoTotal.ToString();
                lblKGChato.Text = kgChatoTotal.ToString();
                lblMetrosChato.Text = comprimentoChato.ToString();

                dataGridView2.Rows.Add(txtNomeChato.Text, qtdeChatoTotal, comprimentoChato, kgChato, numericUpDown2.Value);
            }
            else if (tabPageAtiva == f3)
            {
                comprimentoRedondo += double.Parse(txtComprimentoRedondo.Text) * (int)numericUpDown3.Value;
                double kgRedondo = double.Parse(txtKGRedondo.Text);
                int qtdeRedondo = (int)numericUpDown3.Value;

                int qtdeRedondoTotal = (int)Math.Floor(comprimentoRedondo / 6000);
                double kgRedondoTotal = (comprimentoRedondo / 1000) * double.Parse(txtKGRedondo.Text);

                lblQtdeRedondo.Text = qtdeRedondoTotal.ToString();
                lblKGRedondo.Text = kgRedondoTotal.ToString();
                lblMetrosRedondo.Text = comprimentoRedondo.ToString();

                dataGridView3.Rows.Add(txtNomeRedondo.Text, qtdeRedondoTotal, comprimentoRedondo, kgRedondo, numericUpDown3.Value);
            }
            else if (tabPageAtiva == f4)
            {
                comprimentoCantoneira += double.Parse(txtComprimentoCantoneira.Text) * (int)numericUpDown4.Value;
                double kgCantoneira = double.Parse(txtKGCantoneira.Text);
                int qtdeCantoneira = (int)numericUpDown4.Value;

                int qtdeCantoneiraTotal = (int)Math.Floor(comprimentoCantoneira / 6000);
                double kgCantoneiraTotal = (comprimentoCantoneira / 1000) * double.Parse(txtKGCantoneira.Text);

                lblQtdeCantoneira.Text = qtdeCantoneiraTotal.ToString();
                lblKGCantoneira.Text = kgCantoneiraTotal.ToString();
                lblMetrosCantoneira.Text = comprimentoCantoneira.ToString();

                dataGridView4.Rows.Add(txtNomeCantoneira.Text, qtdeCantoneiraTotal, comprimentoCantoneira, kgCantoneira, numericUpDown4.Value);
            }

        }

        //Form load
        #region
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns["dataGridViewTextBoxColumn1"].  Width = 90;  // Defina o tamanho desejado
            dataGridView1.Columns["dataGridViewTextBoxColumn2"].  Width = 90;  // Defina o tamanho desejado
            dataGridView1.Columns["dataGridViewTextBoxColumn3"].  Width = 100;  // Defina o tamanho desejado
            dataGridView1.Columns["dataGridViewTextBoxColumn4"].  Width = 100;  // Defina o tamanho desejado
            dataGridView1.Columns["dataGridViewTextBoxColumn5"].  Width = 60;  // Defina o tamanho desejado

            dataGridView2.Columns["dataGridViewTextBoxColumn6"].  Width = 90;  // Defina o tamanho desejado
            dataGridView2.Columns["dataGridViewTextBoxColumn7"].  Width = 90;  // Defina o tamanho desejado
            dataGridView2.Columns["dataGridViewTextBoxColumn8"].  Width = 100;  // Defina o tamanho desejado
            dataGridView2.Columns["dataGridViewTextBoxColumn9"].  Width = 100;  // Defina o tamanho desejado
            dataGridView2.Columns["dataGridViewTextBoxColumn10"]. Width = 60;  // Defina o tamanho desejado

            dataGridView3.Columns["dataGridViewTextBoxColumn11"]. Width = 90; // Defina o tamanho desejado
            dataGridView3.Columns["dataGridViewTextBoxColumn12"]. Width = 90; // Defina o tamanho desejado
            dataGridView3.Columns["dataGridViewTextBoxColumn13"]. Width = 100;  // Defina o tamanho desejado
            dataGridView3.Columns["dataGridViewTextBoxColumn14"]. Width = 100;  // Defina o tamanho desejado
            dataGridView3.Columns["dataGridViewTextBoxColumn15"]. Width = 60; // Defina o tamanho desejado

            dataGridView4.Columns["dataGridViewTextBoxColumn16"]. Width = 90;  // Defina o tamanho desejado
            dataGridView4.Columns["dataGridViewTextBoxColumn17"]. Width = 90;  // Defina o tamanho desejado
            dataGridView4.Columns["dataGridViewTextBoxColumn18"]. Width = 100;  // Defina o tamanho desejado
            dataGridView4.Columns["dataGridViewTextBoxColumn19"]. Width = 100;  // Defina o tamanho desejado
            dataGridView4.Columns["dataGridViewTextBoxColumn20"]. Width = 60;  // Defina o tamanho desejado
        }
        

        #endregion


        // M² 
        #region
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            metrosQuadrados = 0;
            lbCalculo.Text = metrosQuadrados.ToString();

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("A quantidade não pode ser igual a 0");
                numericUpDown1.Value = 1;
            }
        }
        private void txtBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }



        #endregion

        // Ferro Chato
        #region
        private void btnCalcularChato_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnResetarChato_Click(object sender, EventArgs e)
        {
            comprimentoChato = 0;
            lblQtdeChato.Text = "0";
            lblKGChato.Text = "0";
            lblMetrosChato.Text = "0";
        }

        private void btnLimparChato_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
        }

        private void txtComprimentoChato_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void txtKGChato_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value == 0)
            {
                MessageBox.Show("A quantidade não pode ser igual a 0");
                numericUpDown2.Value = 1;
            }
        }

        private void numericUpDown2_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }
        #endregion

        // Ferro Redondo
        #region
        private void btnCalcularRedondo_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnResetarRedondo_Click(object sender, EventArgs e)
        {
            comprimentoRedondo = 0;
            lblQtdeRedondo.Text = "0";
            lblKGRedondo.Text = "0";
            lblMetrosRedondo.Text = "0";
        }

        private void btnLimparRedondo_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            dataGridView3.Rows.Clear();
        }
        private void txtComprimentoRedondo_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void txtKGRedondo_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value == 0)
            {
                MessageBox.Show("A quantidade não pode ser igual a 0");
                numericUpDown3.Value = 1;
            }
        }

        private void numericUpDown3_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        #endregion

        // Cantoneira
        #region
        private void btnCalcularCantoneira_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnResetarCantoneira_Click(object sender, EventArgs e)
        {
            comprimentoCantoneira = 0;
            lblQtdeCantoneira.Text = "0";
            lblKGCantoneira.Text = "0";
            lblMetrosCantoneira.Text = "0";
        }

        private void btnLimparCantoneira_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = null;
            dataGridView4.Rows.Clear();
        }
        private void txtComprimentoCantoneira_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void txtKGCantoneira_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown4.Value == 0)
            {
                MessageBox.Show("A quantidade não pode ser igual a 0");
                numericUpDown4.Value = 1;
            }
        }

        private void numericUpDown4_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        #endregion
    }
}
