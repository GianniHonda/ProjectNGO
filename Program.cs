namespace ProjetoONG
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Criar e exibir o formulário de login
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK )
            {
                //Se o login for bem-sucedido, abrir o formulário principal
                Application.Run(new Form1());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}