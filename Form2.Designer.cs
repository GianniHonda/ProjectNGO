namespace ProjetoONG
{
    partial class CadastroAreas
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
            label1 = new Label();
            tbNomeArea = new TextBox();
            label2 = new Label();
            clbDiasFuncionamento = new CheckedListBox();
            label3 = new Label();
            mtbHorario1 = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            mtbHorario2 = new MaskedTextBox();
            label6 = new Label();
            tbLocalInstalacao = new TextBox();
            groupBox1 = new GroupBox();
            btnLimpar = new Button();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome da Área:";
            // 
            // tbNomeArea
            // 
            tbNomeArea.Location = new Point(178, 6);
            tbNomeArea.Name = "tbNomeArea";
            tbNomeArea.Size = new Size(232, 23);
            tbNomeArea.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 2;
            label2.Text = "Dias de Funcionamento:";
            // 
            // clbDiasFuncionamento
            // 
            clbDiasFuncionamento.FormattingEnabled = true;
            clbDiasFuncionamento.Items.AddRange(new object[] { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" });
            clbDiasFuncionamento.Location = new Point(178, 44);
            clbDiasFuncionamento.Name = "clbDiasFuncionamento";
            clbDiasFuncionamento.Size = new Size(120, 130);
            clbDiasFuncionamento.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 199);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 4;
            label3.Text = "Horário de Funcionamento:";
            // 
            // mtbHorario1
            // 
            mtbHorario1.Location = new Point(200, 196);
            mtbHorario1.Mask = "00:00";
            mtbHorario1.Name = "mtbHorario1";
            mtbHorario1.Size = new Size(32, 23);
            mtbHorario1.TabIndex = 5;
            mtbHorario1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 199);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 6;
            label4.Text = "até";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 199);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 7;
            label5.Text = "De";
            // 
            // mtbHorario2
            // 
            mtbHorario2.Location = new Point(267, 196);
            mtbHorario2.Mask = "00:00";
            mtbHorario2.Name = "mtbHorario2";
            mtbHorario2.Size = new Size(31, 23);
            mtbHorario2.TabIndex = 8;
            mtbHorario2.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 241);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 9;
            label6.Text = "Local da Instalação:";
            // 
            // tbLocalInstalacao
            // 
            tbLocalInstalacao.Location = new Point(178, 238);
            tbLocalInstalacao.Name = "tbLocalInstalacao";
            tbLocalInstalacao.Size = new Size(232, 23);
            tbLocalInstalacao.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 261);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 50);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 21);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.RightToLeft = RightToLeft.Yes;
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(335, 21);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // CadastroAreas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 311);
            Controls.Add(groupBox1);
            Controls.Add(tbLocalInstalacao);
            Controls.Add(label6);
            Controls.Add(mtbHorario2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(mtbHorario1);
            Controls.Add(label3);
            Controls.Add(clbDiasFuncionamento);
            Controls.Add(label2);
            Controls.Add(tbNomeArea);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroAreas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Áreas";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNomeArea;
        private Label label2;
        private CheckedListBox clbDiasFuncionamento;
        private Label label3;
        private MaskedTextBox mtbHorario1;
        private Label label4;
        private Label label5;
        private MaskedTextBox mtbHorario2;
        private Label label6;
        private TextBox tbLocalInstalacao;
        private GroupBox groupBox1;
        private Button btnLimpar;
        private Button btnSalvar;
    }
}