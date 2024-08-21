using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CsvHelper;
using ProjetoONG;

namespace ProjetoONG
{
    public partial class FormCadDoador : Form
    {
        private string diretorioPadrao = "C:\\Doador";
        private string nomeArquivo = "DadosDoador.csv";
        private string CaminhoDoArquivo => Path.Combine(diretorioPadrao, nomeArquivo);

        public FormCadDoador()
        {
            InitializeComponent();
            if (!Directory.Exists(diretorioPadrao))
            {
                Directory.CreateDirectory(diretorioPadrao);
            }
            TruncarIDs();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparSelecoesCheckedListBox(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string idDoador = TruncarID(Guid.NewGuid().ToString());
            string doador = tbDoadorInstituicao.Text;
            string endereco = tbEndereco.Text;
            string telefone = mtbTelefone.Text;
            string CPF = new string(mtbCPF.Text.Where(char.IsDigit).ToArray());
            string CNPJ = new string(mtbCNPJ.Text.Where(char.IsDigit).ToArray());
            List<string> tipoDePessoa = clbPessoa.CheckedItems.Cast<object>().Select(item => item?.ToString() ?? "").ToList();

            var newDoador = new Doadores
            {
                ID = idDoador,
                Doador = doador,
                Endereco = endereco,
                Telefone = telefone,
                CPF = CPF,
                CNPJ = CNPJ,
                TipoDePessoa = string.Join(",", tipoDePessoa)
            };

            if (!CabecalhoEscrito())
            {
                EscreverCabecalho();
            }

            using (var writer = new StreamWriter(CaminhoDoArquivo, true, Encoding.UTF8))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecord(newDoador);
                csv.NextRecord();
            }

            MessageBox.Show("Dados salvos com sucesso!");
            LimparCampos();
        }

        private bool CabecalhoEscrito()
        {
            if (!File.Exists(CaminhoDoArquivo)) return false;
            string primeiraLinha = File.ReadLines(CaminhoDoArquivo).FirstOrDefault();
            return primeiraLinha != null && primeiraLinha.Equals("ID,Doador,Endereco,Telefone,CPF,CNPJ,TipoDePessoa");
        }

        private void EscreverCabecalho()
        {
            if (!CabecalhoEscrito())
            {
                using (var writer = new StreamWriter(CaminhoDoArquivo, false, Encoding.UTF8))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<Doadores>();
                    csv.NextRecord();
                }
            }
        }

        private void TruncarIDs()
        {
            if (!File.Exists(CaminhoDoArquivo) || new FileInfo(CaminhoDoArquivo).Length == 0) return;
            var linhas = File.ReadAllLines(CaminhoDoArquivo).Skip(1).ToList();

            using (var writer = new StreamWriter(CaminhoDoArquivo, false, Encoding.UTF8))
            {
                writer.WriteLine("ID,Doador,Endereco,Telefone,CPF,CNPJ,TipoDePessoa");

                foreach (var linha in linhas)
                {
                    var campos = linha.Split(',');
                    campos[0] = TruncarID(campos[0]);
                    writer.WriteLine(string.Join(",", campos));
                }
            }
        }

        private string TruncarID(string idDoador)
        {
            const int comprimentoDesejado = 8;
            return idDoador.Length > comprimentoDesejado ? idDoador.Substring(0, comprimentoDesejado) : idDoador;
        }

        private void LimparCampos()
        {
            tbDoadorInstituicao.Text = string.Empty;
            tbEndereco.Text = string.Empty;
            mtbTelefone.Clear();
            mtbCPF.Clear();
            mtbCNPJ.Clear();
            LimparSelecoesCheckedListBox(clbPessoa);
        }
    }
}
