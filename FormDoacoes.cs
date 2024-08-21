using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoONG.FormCadDoador;

namespace ProjetoONG
{
    public partial class FormDoacoes : Form
    {
        private BindingList<Doadores> doadores;
        private BindingSource bindingSource;
        private readonly string CaminhoDoArquivo = "C:\\Doacoes\\Doadores.csv";

        public FormDoacoes()
        {
            InitializeComponent();

            // Inicializa a lista de doadores e o BindingSource
            doadores = new BindingList<Doadores>();
            bindingSource = new BindingSource { DataSource = doadores };

            // Carregar os doadores do arquivo CSV
            CarregarDoadoresAsync();

            // Vincula o DataGridView ao BindingSource
            dgvDadosDoador.DataSource = bindingSource;

            // Configura as colunas do DataGridView
            ConfigurarColunasDataGridView();

            // Vincula os eventos aos métodos
            btnSalvar.Click += btnSalvar_Click;
            btnLimpar.Click += btnLimpar_Click;
            btnBuscar.Click += btnBuscar_Click;  // Adicionando a associação do evento
        }

        private void ConfigurarColunasDataGridView()
        {
            dgvDadosDoador.AutoGenerateColumns = false;
            dgvDadosDoador.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ID", HeaderText = "ID" });
            dgvDadosDoador.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Doador", HeaderText = "Doador" });
            dgvDadosDoador.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereco" });
            dgvDadosDoador.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone" });
            dgvDadosDoador.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF" });
            dgvDadosDoador.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CNPJ", HeaderText = "CNPJ" });
            dgvDadosDoador.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TipoDePessoa", HeaderText = "Tipo de Pessoa" });
        }

        // Método para carregar doadores do arquivo CSV
        private async void CarregarDoadoresAsync()
        {
            var doadoresList = await CsvHelperUtility.LoadCsvDataAsync<Doadores>(CaminhoDoArquivo);
            doadores = new BindingList<Doadores>(doadoresList);
            bindingSource.DataSource = doadores;

            MessageBox.Show($"Dados carregados: {doadores.Count}");
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists("C:\\Doacoes"))
                {
                    Directory.CreateDirectory("C:\\Doacoes");
                }

                string caminhoDoadores = Path.Combine("C:\\Doacoes", "Doadores.csv");

                // Adicionar novos doadores à lista
                doadores = new BindingList<Doadores>(bindingSource.DataSource as List<Doadores>);
                await CsvHelperUtility.SaveCsvDataAsync(caminhoDoadores, doadores.ToList());
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para buscar doadores pelo nome
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nomeDoador = tbNomeDoador.Text.Trim();
            if (string.IsNullOrEmpty(nomeDoador))
            {
                MessageBox.Show("Por favor, insira o nome do doador.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (doadores.Count == 0)
            {
                MessageBox.Show("Nenhum dado carregado.");
                return;
            }

            var resultadoBusca = doadores.Where(d => d.Doador != null && d.Doador.Contains(nomeDoador, StringComparison.OrdinalIgnoreCase)).ToList();
            bindingSource.DataSource = resultadoBusca.Any() ? resultadoBusca : doadores;
        }

        // Método para limpar os campos do formulário
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbNomeDoador.Text = string.Empty;
            tbValor.Text = string.Empty;
            tbItemDoado.Text = string.Empty;
            cbFrequenciaDoacoes.SelectedIndex = -1;
            dgvDadosDoador.Rows.Clear();

            LimparSelecoesCheckedListBox(clbTipoDoacao);
            LimparSelecoesCheckedListBox(clbFrequencia);
        }

        // Método auxiliar para limpar seleções de CheckedListBox
        private void LimparSelecoesCheckedListBox(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }
    }
}
