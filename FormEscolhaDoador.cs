using CsvHelper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjetoONG;

namespace ProjetoONG
{
    public partial class FormEscolhaDoador : Form
    {
        private List<FormCadDoador> doadores;

        // Propriedade para armazenar o doador selecionado
        public FormCadDoador DoadorSelecionado { get; private set; }

        public FormEscolhaDoador(List<FormCadDoador> doadores)
        {
            InitializeComponent();
            this.doadores = doadores;

            //Preencha o ComboBox com as opções de doadores
            PreencherComboBox();
        }

        private void PreencherComboBox()
        {
            foreach (var doador in doadores)
            {
                // Adiciona o objeto Doadores inteiro ao ComboBox
                cbNomeDoador.Items.Add(doador);
            }

            //Seleciona o primeiro item por padrão
            if (cbNomeDoador.Items.Count > 0)
            {
                cbNomeDoador.SelectedIndex = 0;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Verifica se algum doador foi selecionado no ComboBox
            if (cbNomeDoador.SelectedIndex != -1)
            {
                // Obtém o objeto Doadores diretamente do ComboBox
                DoadorSelecionado = (FormCadDoador)cbNomeDoador.SelectedItem;

                //Define o resultado do diálogo como OK
                DialogResult = DialogResult.OK;

                //Fecha o formulário
                Close();
            }
            else
            { 
                MessageBox.Show("Por favor, selecione um doador da lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Define o resultado do diálogo como cancelar
            DialogResult = DialogResult.Cancel;

            //Fecha o formulário
            Close();
        }
    }
}
