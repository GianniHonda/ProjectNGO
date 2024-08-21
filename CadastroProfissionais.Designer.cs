namespace ProjetoONG
{
    partial class CadastroProfissionais
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbNome = new TextBox();
            tbEndereco = new TextBox();
            mtbTelefone = new MaskedTextBox();
            tbArea = new TextBox();
            clbSemana = new CheckedListBox();
            mtbHorario1 = new MaskedTextBox();
            text = new Label();
            label7 = new Label();
            mtbHorario2 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            btnLimpar = new Button();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Endereço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 104);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 3;
            label4.Text = "Área de Atuação:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 188);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 4;
            label5.Text = "Atuação na Semana:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 343);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 5;
            label6.Text = "Horários de Atuação:";
            // 
            // tbNome
            // 
            tbNome.Location = new Point(150, 23);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(299, 23);
            tbNome.TabIndex = 6;
            // 
            // tbEndereco
            // 
            tbEndereco.Location = new Point(150, 62);
            tbEndereco.Name = "tbEndereco";
            tbEndereco.Size = new Size(299, 23);
            tbEndereco.TabIndex = 7;
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(150, 104);
            mtbTelefone.Mask = "(00) 90000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(98, 23);
            mtbTelefone.TabIndex = 8;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(150, 144);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(299, 23);
            tbArea.TabIndex = 9;
            // 
            // clbSemana
            // 
            clbSemana.FormattingEnabled = true;
            clbSemana.Items.AddRange(new object[] { "Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado" });
            clbSemana.Location = new Point(150, 188);
            clbSemana.Name = "clbSemana";
            clbSemana.Size = new Size(120, 130);
            clbSemana.TabIndex = 10;
            // 
            // mtbHorario1
            // 
            mtbHorario1.Location = new Point(181, 340);
            mtbHorario1.Mask = "00:00";
            mtbHorario1.Name = "mtbHorario1";
            mtbHorario1.Size = new Size(33, 23);
            mtbHorario1.TabIndex = 11;
            mtbHorario1.ValidatingType = typeof(DateTime);
            // 
            // text
            // 
            text.AutoSize = true;
            text.Location = new Point(220, 343);
            text.Name = "text";
            text.Size = new Size(23, 15);
            text.TabIndex = 12;
            text.Text = "até";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(151, 343);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 13;
            label7.Text = "De";
            // 
            // mtbHorario2
            // 
            mtbHorario2.Location = new Point(249, 340);
            mtbHorario2.Mask = "00:00";
            mtbHorario2.Name = "mtbHorario2";
            mtbHorario2.Size = new Size(32, 23);
            mtbHorario2.TabIndex = 14;
            mtbHorario2.ValidatingType = typeof(DateTime);
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom;
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Location = new Point(-5, 369);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 43);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(379, 14);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 1;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(17, 14);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // CadastroProfissionais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 409);
            Controls.Add(groupBox1);
            Controls.Add(mtbHorario2);
            Controls.Add(label7);
            Controls.Add(text);
            Controls.Add(mtbHorario1);
            Controls.Add(clbSemana);
            Controls.Add(tbArea);
            Controls.Add(mtbTelefone);
            Controls.Add(tbEndereco);
            Controls.Add(tbNome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroProfissionais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroProfissionais";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbNome;
        private TextBox tbEndereco;
        private MaskedTextBox mtbTelefone;
        private TextBox tbArea;
        private CheckedListBox clbSemana;
        private MaskedTextBox mtbHorario1;
        private Label text;
        private Label label7;
        private MaskedTextBox mtbHorario2;
        private GroupBox groupBox1;
        private Button btnLimpar;
        private Button btnSalvar;
    }
}