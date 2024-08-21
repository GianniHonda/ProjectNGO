using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Windows.Forms;

namespace ProjetoONG
{
    public partial class FormBuscaProfissionais : Form
    {
        //Adiciona uma propriedade para a lista de diretórios
        public List<string> Diretorios { get; set; }
        public FormBuscaProfissionais()
        {
            InitializeComponent();

            //Carrega os diretórios durante a inicialização do formulário
            CarregarDiretorios();

            if (Diretorios == null)
            {
                MessageBox.Show("A lista de diretórios está vazia ou não foi carregada ainda");
            }
            else if (Diretorios.Count == 0)
            {
                MessageBox.Show("A lista de diretórios está vazia");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbNomeProfissional.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Iniciando busca...");

            if (Diretorios == null || Diretorios.Count == 0)
            {
                Console.WriteLine("A lista de diretórios está vazia ou não foi carregada ainda.");
                MessageBox.Show("A lista de diretórios está vazia ou não foi carregada ainda.");
                return;
            }

            string palavraChave = tbNomeProfissional.Text.Trim();

            foreach (string diretorio in Diretorios)
            {
                Console.WriteLine($"Procurando em: {diretorio}");

                try
                {
                    if (Directory.Exists(diretorio))
                    {
                        string[] arquivos = Directory.GetFiles(diretorio, "*.csv", System.IO.SearchOption.AllDirectories);
                        Console.WriteLine($"Encontrados {arquivos.Length} arquivos no diretório e subdiretórios.");

                        foreach (string caminhoDoArquivo in arquivos)
                        {
                            Console.WriteLine($"Verificando arquivo: {caminhoDoArquivo}");

                            try
                            {
                                using (TextFieldParser parser = new TextFieldParser(caminhoDoArquivo))
                                {
                                    parser.TextFieldType = FieldType.Delimited;
                                    parser.SetDelimiters(",");

                                    while (!parser.EndOfData)
                                    {
                                        string[] campos = parser.ReadFields();

                                        //verifique se a palavra-chave está em um dos campos
                                        foreach (string campo in campos)
                                        {
                                            if (campo.IndexOf(palavraChave, StringComparison.OrdinalIgnoreCase) >= 0)
                                            {
                                                Console.WriteLine("Palavra-chave encontrada!");

                                                //Adiciona verificação antes de abrir o arquivo
                                                if (MessageBox.Show("Deseja abrir o arquivo?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                                {
                                                    Console.WriteLine($"Abrindo arquivo: {caminhoDoArquivo}");
                                                    System.Diagnostics.Process.Start("notepad.exe", caminhoDoArquivo);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Usuário optou por não abrir o arquivo.");
                                                }
                                                return; //encerra o loop se encontrar a palavra chave em algum campo
                                            }
                                        }
                                    }
                                }
                                Console.WriteLine($"Palavra-chave não encontrada no arquivo ({caminhoDoArquivo}).");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Erro ao ler o arquivo {caminhoDoArquivo}: {ex.Message}");
                            }
                        }
                        Console.WriteLine("Palavra-chave não encontrada nos arquivos do diretório e subdiretórios.");
                    }
                    else
                    {
                        Console.WriteLine($"O diretório {diretorio} não existe.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao acessar o diretório {diretorio}: {ex.Message}");
                }
            }

            Console.WriteLine("A palavra-chave não foi encontrada nos arquivos.");
            MessageBox.Show("A palavra-chave não foi encontrada nos arquivos.");
        }

        private void CarregarDiretorios()
        {
            Diretorios = new List<string>();
            Diretorios.Add("C:\\Profissionais");
        }

       private void backgroundWorker1_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
        {
            if (Diretorios != null && Diretorios.Count > 0) 
            {
                Console.WriteLine("Diretórios carregados com sucesso!");
            }
            else
            {
                MessageBox.Show("A lista de diretórios está vazia ou não foi carregada ainda");
            }
        }
    }
}
