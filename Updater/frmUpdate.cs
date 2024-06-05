
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceCalc_PRO
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
            this.Shown += new EventHandler(frmUpdate_Shown);
        }

        private async void frmUpdate_Shown(object sender, EventArgs e)
        {
            await UpdateApplicationAsync();
        }

        private async Task UpdateApplicationAsync()
        {
            using (var client = new WebClient())
            {
                try
                {
                    UpdateStatus("Iniciando atualização...");

                    await Task.Delay(1000);

                    UpdateStatus("Removendo arquivo antigo...");

                    if (File.Exists(@".\.exe"))
                    {
                        File.Delete(@".\.exe");
                    }

                    UpdateStatus("Baixando nova versão...");

                    await client.DownloadFileTaskAsync(new Uri(""), @".zip");

                    UpdateStatus("Extraindo nova versão...");

                    string zipPath = @".\.zip";
                    string extractPath = @".\";
                    ZipFile.ExtractToDirectory(zipPath, extractPath);

                    UpdateStatus("Limpando arquivos temporários...");

                    File.Delete(zipPath);

                    UpdateStatus("Atualização concluída com sucesso!");

                    MessageBox.Show("Atualizado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Process.Start(@".\.exe");

                    this.Close();
                }
                catch (Exception ex)
                {
                    UpdateStatus($"Erro ao atualizar: {ex.Message}");
                    MessageBox.Show($"Erro ao atualizar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private void UpdateStatus(string message)
        {
            if (txtAtualizacao.InvokeRequired)
            {
                txtAtualizacao.Invoke(new Action(() => txtAtualizacao.AppendText(message + Environment.NewLine)));
            }
            else
            {
                txtAtualizacao.AppendText(message + Environment.NewLine);
            }
        }
    }
}