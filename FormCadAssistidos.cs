using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProjetoONG
{
    public partial class FormCadAssistidos : Form
    {
        //define o diretorio padrao para salvar os arquivos
        private string diretorioPadrao = "C:\\Assistidos";

        private string nomeArquivo = "CadastroAssistidos.csv"; //nome do arquivo unico
        
        //caminho completo do arquivo
        private string CaminhoDoArquivo => Path.Combine(diretorioPadrao, nomeArquivo);

        public FormCadAssistidos()
        {
            InitializeComponent();

            //verifica se o diretorio padrao existe, se não, cria
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
            string nome = tbNome.Text;
            string endereco = tbEndereco.Text;
            string areaAssist = tbAreaAssist.Text;
            string dataNasc = mtbDataNascimento.Text;
            string telefone = mtbTelefone.Text;
            List<string> sexo = new List<string>();

            foreach (var item in clbSexo.CheckedItems)
            {
                sexo.Add(item.ToString());
            }

            //cabeçalho das colunas
            string cabecalho = "Nome,Endereco,AreaAsssist,DataNasc,Telefone,Sexo";

            //cria uma linha CSV com os dados
            string dadosParaSalvar = $"{nome},{endereco},{areaAssist},{dataNasc},{telefone},";

            //adiciona os gêneros separados por virgulas
            dadosParaSalvar += string.Join(",", sexo);

            //define a extenção como .csv
            string caminhoDoArquivo = Path.Combine(diretorioPadrao, $"{nomeArquivo}.csv");

            //abre o arquivo no modo de escrita (append)
            using (StreamWriter writer = new StreamWriter(caminhoDoArquivo, true))
            {
                //se o arquivo estiver vazio, escreve o cabeçalho
                if (writer.BaseStream.Length == 0)
                {
                    writer.WriteLine(cabecalho);
                }

                //escreve dados no arquivo
                writer.WriteLine(dadosParaSalvar);
            }

            MessageBox.Show("Dados salvos com sucesso!");

            //limpa os campos apos o sallvamento
            LimparCampos();
            }

        private void LimparCampos()
        {
            tbNome.Text = string.Empty;
            tbEndereco.Text = string.Empty;
            tbAreaAssist.Text = string.Empty;
            mtbDataNascimento.Clear();
            mtbTelefone.Clear();
            LimparSelecoesCheckedListBox(clbSexo);
        }
        }
    }
