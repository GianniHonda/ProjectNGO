namespace ProjetoONG
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbSenha = new TextBox();
            btnLogin = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(65, 12);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(154, 23);
            tbLogin.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 50);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // tbSenha
            // 
            tbSenha.Location = new Point(65, 47);
            tbSenha.Name = "tbSenha";
            tbSenha.PasswordChar = '*';
            tbSenha.Size = new Size(154, 23);
            tbSenha.TabIndex = 3;
            tbSenha.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(239, 15);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(239, 47);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 82);
            Controls.Add(btnLimpar);
            Controls.Add(btnLogin);
            Controls.Add(tbSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLogin;
        private Label label1;
        private Label label2;
        private TextBox tbSenha;
        private Button btnLogin;
        private Button btnLimpar;
    }
}