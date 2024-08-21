using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoONG
{
    public partial class LoginForm : Form
    {
        //Define uma variável para armazenar o tipo de acesso do usuário 
        private static bool acessoRestrito;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string loginDigitado = tbLogin.Text;
            string senhaDigitada = tbSenha.Text;

            if ((loginDigitado == Credenciais.Login1 && senhaDigitada == Credenciais.Senha1))
            {
                //Define o acesso como restrito para o usuário userC
                acessoRestrito = true;
                //Login bem sucedido
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (loginDigitado == Credenciais.Login2 && senhaDigitada == Credenciais.Senha2)
            {
                //Define o acesso como total para o usuário userG
                acessoRestrito = false;
                //Login bem sucedido
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                //Login inválido
                MessageBox.Show("Login ou senha incorretos. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbLogin.Clear();
                tbSenha.Clear();
                tbLogin.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbLogin.Clear();
            tbSenha.Clear();
            tbLogin.Focus();
        }

        //Método público para obter o tipo de acesso do usuário
        public static bool AcessRestrito()
        {
            return acessoRestrito;
        }
    }

    public static class Credenciais
    {
        public const string Login1 = "userC";
        public const string Senha1 = "acessogeral123";

        public const string Login2 = "userG";
        public const string Senha2 = "acessorestrito321";
    }
}
