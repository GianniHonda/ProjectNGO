using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoONG
{
    public partial class FormOrcamento : Form
    {
        private static List<decimal> valoresOutrasReceitas = new List<decimal>();
        private static string caminhoArquivo = @"C:\Doacoes\OutrasReceitas.csv"; // Certifique-se de que o caminho está correto

        public FormOrcamento()
        {
            InitializeComponent();
            CarregarValoresOutrasReceitas();
            AtualizarTotalAtivos();
        }

        private void FormOrcamento_Load(object sender, EventArgs e)
        {
            CarregarValoresOutrasReceitas();
            AtualizarTotalAtivos();
        }

        private void CarregarValoresOutrasReceitas()
        {
            valoresOutrasReceitas.Clear();

            try
            {
                using (var reader = new StreamReader(caminhoArquivo))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    while (csv.Read())
                    {
                        var valor = csv.GetField<decimal>("Valor");
                        valoresOutrasReceitas.Add(valor);
                    }
                }

                Console.WriteLine($"Valores carregados: {valoresOutrasReceitas.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar outras receitas: {ex.Message}");
            }
        }

        private void btnAdReceita_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbAdReceita.Text, out decimal valor))
            {
                AdicionarOutraReceita(valor);
                Console.WriteLine("Outra receita adicionada com sucesso.");
                AtualizarTotalAtivos();
                LimparTextBoxReceita();
            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparTextBoxReceita()
        {
            tbAdReceita.Text = string.Empty;
        }

        private void AtualizarTotalAtivos()
        {
            decimal totalAtivos = CalcularTotalAtivos();
            Console.WriteLine($"Total de ativos calculado: {totalAtivos}");
            lbTotAtivos.Text = totalAtivos.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTextBoxReceita();
        }

        private decimal CalcularTotalAtivos()
        {
            decimal total = valoresOutrasReceitas.Sum();
            Console.WriteLine($"Total calculado: {total}");
            return total;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (decimal.TryParse(tbAdReceita.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal valorNovaReceita))
                {
                    AdicionarOutraReceita(valorNovaReceita);
                    Console.WriteLine("Nova receita adicionada com sucesso.");
                    AtualizarTotalAtivos();
                    LimparTextBoxReceita();
                }
                else
                {
                    MessageBox.Show("Por favor insira um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string diretorioDoacoes = "C:\\Doacoes";
                string caminhoOutrasReceitas = Path.Combine(diretorioDoacoes, "OutrasReceitas.csv");

                if (!Directory.Exists(diretorioDoacoes))
                {
                    Directory.CreateDirectory(diretorioDoacoes);
                }

                bool arquivoExiste = File.Exists(caminhoOutrasReceitas);
                Console.WriteLine($"Salvando nova receita em: {caminhoOutrasReceitas}");

                using (var writer = new StreamWriter(caminhoOutrasReceitas, true, Encoding.UTF8))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    if (!arquivoExiste)
                    {
                        csv.WriteHeader<Receita>();
                        csv.NextRecord();
                    }

                    csv.WriteRecord(new Receita { Valor = valorNovaReceita });
                    csv.NextRecord();

                    MessageBox.Show("Nova receita salva com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdicionarOutraReceita(decimal valor)
        {
            valoresOutrasReceitas.Add(valor);
            Console.WriteLine($"Receita adicionada: {valor}");
        }

        public class Receita
        {
            public decimal Valor { get; set;}
        }
    }
}
