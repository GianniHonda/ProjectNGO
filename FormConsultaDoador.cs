using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ProjetoONG;

namespace ProjetoONG
{
    public partial class FormConsultaDoador : Form
    {
        public FormConsultaDoador()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string caminhoDoArquivoDoador = "C:\\Doador\\DadosDoador.csv";
            string palavraChave = tbNomeDoador.Text;

            try
            {
                if (File.Exists(caminhoDoArquivoDoador))
                {
                    using (var reader = new StreamReader(caminhoDoArquivoDoador))
                    using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true }))
                    {
                        csv.Context.RegisterClassMap<DoadoresMap>();
                        var records = csv.GetRecords<Doadores>().ToList();

                        foreach (var doador in records)
                        {
                            if (doador.Doador.Contains(palavraChave, StringComparison.OrdinalIgnoreCase))
                            {
                                if (MessageBox.Show("Deseja abrir o arquivo?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    System.Diagnostics.Process.Start("notepad.exe", caminhoDoArquivoDoador);
                                }
                                return;
                            }
                        }
                        MessageBox.Show("A palavra-chave não foi encontrada nos registros de doadores.");
                    }
                }
                else
                {
                    MessageBox.Show($"O arquivo {caminhoDoArquivoDoador} não existe.");
                }
            }
            catch (CsvHelperException ex)
            {
                MessageBox.Show($"Erro ao acessar o arquivo CSV: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao acessar o arquivo {caminhoDoArquivoDoador}: {ex.Message}");
            }
        }
    }
}
