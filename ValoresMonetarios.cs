using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ProjetoONG
{
    public class ValorMonetario
    {
        public decimal Valor { get; set; }
        public string Descricao { get; set; }

        public ValorMonetario(decimal valor, string descricao)
        {
            Valor = valor;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"{Descricao}: {Valor:C}";
        }
    }

    public static class ValoresMonetarios
    {
        private static List<decimal> doacoesMonetarias = new List<decimal>();
        private static List<decimal> outrasReceitas = new List<decimal>();

        public static void Inicializar()
        {
            // Limpa as listas antes de carregar novamente para evitar duplicidade
            doacoesMonetarias.Clear();
            outrasReceitas.Clear();

            // Carregar doações monetárias do arquivo doações
            CarregarDoacoesMonetarias();

            // Carregar outras receitas do arquivo OutrasReceitas
            CarregarOutrasReceitas();
        }

        public static void CarregarDoacoesMonetarias()
        {
            string caminhoDoacoes = "C:\\Doacoes\\Doacoes.csv";
            if (File.Exists(caminhoDoacoes))
            {
                doacoesMonetarias = CarregarValores(caminhoDoacoes, "Valor");
            }
        }

        public static void CarregarOutrasReceitas()
        {
            string caminhoOutrasReceitas = "C:\\Doacoes\\OutrasReceitas.csv";
            if (File.Exists(caminhoOutrasReceitas))
            {
                outrasReceitas = CarregarValores(caminhoOutrasReceitas, "Valor");
            }
        }

        public static decimal CalcularTotalAtivos()
        {
            return doacoesMonetarias.Sum() + outrasReceitas.Sum();
        }

        public static void AdicionarDoacaoMonetaria(decimal valor)
        {
            doacoesMonetarias.Add(valor);
        }

        public static void AdicionarOutraReceita(decimal valor)
        {
            outrasReceitas.Add(valor);
            Console.WriteLine($"Outra receita adicionada: {valor}");
        }

        private static List<decimal> CarregarValores(string caminhoArquivo, string nomeCampo)
        {
            List<decimal> valores = new List<decimal>();

            try
            {
                using (var reader = new StreamReader(caminhoArquivo))
                {
                    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = true,
                        MissingFieldFound = null,
                    };

                    using (var csv = new CsvReader(reader, config))
                    {
                        while (csv.Read())
                        {
                            if (decimal.TryParse(csv.GetField(nomeCampo), out decimal valor))
                            {
                                valores.Add(valor);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar valores: {ex.Message}");
            }

            return valores;
        }

        public static void AtualizarTotais()
        {
            //Atualiza as listas de doações e receitas
            Inicializar();
        }
    }
}
