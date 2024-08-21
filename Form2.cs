using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProjetoONG
{
    public partial class CadastroAreas : Form
    {
        //define o diretório padrão para salvar os arquivos
        private string diretorioPadrao = "C:\\Areas";

        //nome do arquivo unico
        private string nomeArquivo = "CadastroAreas.csv";

        //caminho completo do arquivo
        private string CaminhoDoArquivo => Path.Combine(diretorioPadrao, nomeArquivo);
        public CadastroAreas()
        {
            InitializeComponent();

            //verifica se o diretorio padrão existe, se não, cria
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
            string nomeArea = tbNomeArea.Text;
            string localInstalacao = tbLocalInstalacao.Text;
            string horario1 = mtbHorario1.Text;
            string horario2 = mtbHorario2.Text;
            List<string> diasFuncionamento = new List<string>();

            foreach (var item in clbDiasFuncionamento.CheckedItems)
            {
                diasFuncionamento.Add(item.ToString());
            }

            //Cabeçalho das colunas
            string cabecalho = "NomeArea,LocalInstalacao,Horario1,Horario2";

            //dados do registro
            string dadosParaSalvar = $"{nomeArea},{localInstalacao},{horario1},{horario2},";

            //adiciona os dias de funcionamento separados por vírgula
            dadosParaSalvar += string.Join(",", diasFuncionamento);

            //define a extensão como .csv
            string caminhoDoArquivo = Path.Combine(diretorioPadrao, $"{nomeArquivo}.csv");

            //abre o arquivo no modo de escrita (append)
            using (StreamWriter writer = new StreamWriter(caminhoDoArquivo, true))
            {
                if (writer.BaseStream.Length == 0) 
                {
                    writer.WriteLine(cabecalho);
                }

                //escreva os dados no arquivo
                writer.WriteLine(dadosParaSalvar);
            }
                MessageBox.Show("Dados salvos com sucesso!");

            //Limpa os campos após o salvamento
            LimparCampos();
            }

        private void LimparCampos()
        {
            tbLocalInstalacao.Text = string.Empty;
            tbNomeArea.Text = string.Empty;
            mtbHorario1.Clear();
            mtbHorario2.Clear();
            LimparSelecoesCheckedListBox(clbDiasFuncionamento);
        }
    }
    }
