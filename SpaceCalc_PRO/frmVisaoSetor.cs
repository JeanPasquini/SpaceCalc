﻿using System;
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
    public partial class frmVisaoSetor : Form
    {
        public frmVisaoSetor()
        {
            InitializeComponent();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            frmCadastroSetor frm = new frmCadastroSetor();
            frm.ShowDialog();
            atualizaGrid();
        }
        private async void atualizaGrid()
        {
            showWaitForm.Open();

            try
            {
                DataTable table = await MongoDB.DT("ZSETOR");

                if (table != null)
                {
                    kryptonDataGridView1.DataSource = table;
                }
                else
                {
                    Console.WriteLine("Nenhum dado encontrado para preencher o DataGridView.");
                    kryptonDataGridView1.DataSource = null;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Houve um erro:" + er.Message, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    showWaitForm.Close();
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

                    DialogResult result = MessageBox.Show($@"Deseja exclui o Produto de ID: {id}?", "Pergunta do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        bool deleteResult = await MongoDB.deleteDT("ZSETOR", id);

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
    }
}