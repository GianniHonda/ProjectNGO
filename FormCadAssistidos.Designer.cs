namespace ProjetoONG
{
    partial class FormCadAssistidos
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
            tbNome = new TextBox();
            label2 = new Label();
            mtbDataNascimento = new MaskedTextBox();
            label3 = new Label();
            clbSexo = new CheckedListBox();
            label4 = new Label();
            tbEndereco = new TextBox();
            label5 = new Label();
            mtbTelefone = new MaskedTextBox();
            label6 = new Label();
            tbAreaAssist = new TextBox();
            groupBox1 = new GroupBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(138, 12);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(263, 23);
            tbNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 2;
            label2.Text = "Data de Nascimento:";
            // 
            // mtbDataNascimento
            // 
            mtbDataNascimento.Location = new Point(138, 46);
            mtbDataNascimento.Mask = "00/00/0000";
            mtbDataNascimento.Name = "mtbDataNascimento";
            mtbDataNascimento.Size = new Size(96, 23);
            mtbDataNascimento.TabIndex = 3;
            mtbDataNascimento.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 54);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "Sexo:";
            // 
            // clbSexo
            // 
            clbSexo.FormattingEnabled = true;
            clbSexo.Items.AddRange(new object[] { "Feminino", "Masculino" });
            clbSexo.Location = new Point(281, 46);
            clbSexo.Name = "clbSexo";
            clbSexo.Size = new Size(120, 40);
            clbSexo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Endereço:";
            // 
            // tbEndereco
            // 
            tbEndereco.Location = new Point(138, 104);
            tbEndereco.Name = "tbEndereco";
            tbEndereco.Size = new Size(263, 23);
            tbEndereco.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 154);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "Telefone:";
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(138, 151);
            mtbTelefone.Mask = "(999) 00000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(104, 23);
            mtbTelefone.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 212);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 10;
            label6.Text = "Área de Assistência:";
            // 
            // tbAreaAssist
            // 
            tbAreaAssist.Location = new Point(134, 212);
            tbAreaAssist.Name = "tbAreaAssist";
            tbAreaAssist.Size = new Size(267, 23);
            tbAreaAssist.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Location = new Point(1, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 56);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(325, 12);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(16, 12);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 0;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FormCadAssistidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 290);
            Controls.Add(groupBox1);
            Controls.Add(tbAreaAssist);
            Controls.Add(label6);
            Controls.Add(mtbTelefone);
            Controls.Add(label5);
            Controls.Add(tbEndereco);
            Controls.Add(label4);
            Controls.Add(clbSexo);
            Controls.Add(label3);
            Controls.Add(mtbDataNascimento);
            Controls.Add(label2);
            Controls.Add(tbNome);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadAssistidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Assistidos";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNome;
        private Label label2;
        private MaskedTextBox mtbDataNascimento;
        private Label label3;
        private CheckedListBox clbSexo;
        private Label label4;
        private TextBox tbEndereco;
        private Label label5;
        private MaskedTextBox mtbTelefone;
        private Label label6;
        private TextBox tbAreaAssist;
        private GroupBox groupBox1;
        private Button btnSalvar;
        private Button btnLimpar;
    }
}