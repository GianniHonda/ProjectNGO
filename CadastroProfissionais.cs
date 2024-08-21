using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace ProjetoONG
{
    public partial class CadastroProfissionais : Form
    {
        //define o diretorio padrao para salvar os arquivos
        private string diretorioPadrao = "C:\\Profissionais";

        //Nome do arquivo único
        private string nomeArquivo = "CadastroProfissionais.csv";

        //caminho completo do arquivo
        private string CaminhoDoArquivo => Path.Combine(diretorioPadrao, nomeArquivo);

        public CadastroProfissionais()
        {
            InitializeComponent();

            //verifica se o diretório padrão existe, se não, cria
            if (!Directory.Exists(diretorioPadrao))
            {
                Directory.CreateDirectory(diretorioPadrao);
            }
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
            //Esses são os dados dos campos
            string nome = tbNome.Text;
            string endereco = tbEndereco.Text;
            string area = tbArea.Text;
            string telefone = mtbTelefone.Text;
            string horario1 = mtbHorario1.Text;
            string horario2 = mtbHorario2.Text;
            List<string> diasSelecionados = new List<string>();
            foreach (var item in clbSemana.CheckedItems)
            {
                diasSelecionados.Add(item.ToString());
            }

            //cabeçalho das colunas
            string cabecalho = "Nome,Endereco,Area,Telefone,Horario1,Horario2,DiasSelecionados";

            //Dados do regisstro
            string dadosParaSalvar = $"{nome},{endereco},{area},{telefone},{horario1},{horario2},";

            //Adiciona os dias selecionados separados por virgula
            dadosParaSalvar += string.Join(",", diasSelecionados);

            //Define a extensão como .csv
            string caminhoDoArquivo = Path.Combine(diretorioPadrao, $"{nomeArquivo}.csv");

            //Abre o arquivo no modo de escrita (append)
            using (StreamWriter writer = new StreamWriter(caminhoDoArquivo, true))
            {
                //se o arquivo estiver vazio, escreve o cabeçalho
                if (writer.BaseStream.Length == 0)
                {
                    writer.WriteLine(cabecalho);
                }

                //escreve os dados no arquivo
                writer.WriteLine(dadosParaSalvar);
            }
                MessageBox.Show("Dados salvos com sucesso!");

            //Limpa os campos após o salvamento
            LimparCampos();
            }

        private void LimparCampos()
        {
            tbNome.Text = string.Empty;
            tbEndereco.Text = string.Empty;
            tbArea.Text = string.Empty;
            mtbTelefone.Clear();
            mtbHorario1.Clear();
            mtbHorario2.Clear();
            LimparSelecoesCheckedListBox(clbSemana);
        }
        }
    }
