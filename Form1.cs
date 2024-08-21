using System;
using System.Windows.Forms;

namespace ProjetoONG
{
    public partial class Form1 : Form
    {
        private List<string> diretorios = new List<string>();
        public Form1()
        {
            InitializeComponent();
            VerificarAcessoUsuario();
        }

        private void VerificarAcessoUsuario()
        {
            //Verifica o tipo de acesso do usuário
            if (LoginForm.AcessRestrito())
            {
                //Se o acesso for reestrito, oculta ou desabilita o item de menu "Interno"
                internoToolStripMenuItem1.Visible = false; 
            }
            else
            {
                //Se o acesso for total, mantém o item de menu "Interno"
                internoToolStripMenuItem1.Visible = true;
            }
        }

        private void cadastroDeProfissionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria uma instância do formulário que desejo abrir
            CadastroProfissionais cadastroProfissionais = new CadastroProfissionais();

            //Exibe o formulário
            cadastroProfissionais.Show();
        }

        private void cadastroDeÁreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAreas cadastroAreas = new CadastroAreas();

            cadastroAreas.Show();
        }

        private void cadastroDeAssistidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadAssistidos formCadAssistidos = new FormCadAssistidos();

            formCadAssistidos.Show();
        }

        private void dadosDaÁreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscaArea formBuscaArea = new FormBuscaArea();
            //formBuscaArea.Diretorios = diretorios; // Certifique-se de que 'diretorios' está populado corretamente
            formBuscaArea.Show();
        }

        private void dadosDoProfissionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscaProfissionais formBuscaProfissionais = new FormBuscaProfissionais();
            formBuscaProfissionais.Show();
        }

        private void dadosDoAssistidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscaAssistido formBuscaAssistido = new FormBuscaAssistido();
            formBuscaAssistido.Show();
        }

        private void doadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadDoador formCadDoador = new FormCadDoador();
            formCadDoador.Show();
        }

        private void dadosDoDoadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaDoador formConsultaDoador = new FormConsultaDoador();
            formConsultaDoador.Show();
        }

        private void doaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDoacoes formDoacoes = new FormDoacoes();
            formDoacoes.Show();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDespesas formDespesas = new FormDespesas();
            formDespesas.Show();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrcamento formOrcamento = new FormOrcamento();
            formOrcamento.Show();
        }
    }
}
