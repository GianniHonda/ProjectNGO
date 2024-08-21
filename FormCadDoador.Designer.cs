namespace ProjetoONG
{
    partial class FormCadDoador
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
            tbDoadorInstituicao = new TextBox();
            label2 = new Label();
            tbEndereco = new TextBox();
            label3 = new Label();
            mtbTelefone = new MaskedTextBox();
            label4 = new Label();
            clbPessoa = new CheckedListBox();
            label5 = new Label();
            mtbCPF = new MaskedTextBox();
            label6 = new Label();
            mtbCNPJ = new MaskedTextBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Doador/Instituuição:";
            // 
            // tbDoadorInstituicao
            // 
            tbDoadorInstituicao.Location = new Point(134, 6);
            tbDoadorInstituicao.Name = "tbDoadorInstituicao";
            tbDoadorInstituicao.Size = new Size(363, 23);
            tbDoadorInstituicao.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Endereço:";
            // 
            // tbEndereco
            // 
            tbEndereco.Location = new Point(134, 40);
            tbEndereco.Name = "tbEndereco";
            tbEndereco.Size = new Size(363, 23);
            tbEndereco.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefone:";
            // 
            // mtbTelefone
            // 
            mtbTelefone.Location = new Point(134, 78);
            mtbTelefone.Mask = "(000) 0000-0000";
            mtbTelefone.Name = "mtbTelefone";
            mtbTelefone.Size = new Size(100, 23);
            mtbTelefone.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 120);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 6;
            label4.Text = "Tipo de pessoa:";
            // 
            // clbPessoa
            // 
            clbPessoa.FormattingEnabled = true;
            clbPessoa.Items.AddRange(new object[] { "Pessoa física", "Pessoa jurídica" });
            clbPessoa.Location = new Point(134, 120);
            clbPessoa.Name = "clbPessoa";
            clbPessoa.Size = new Size(109, 40);
            clbPessoa.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 183);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "CPF:";
            // 
            // mtbCPF
            // 
            mtbCPF.Location = new Point(134, 180);
            mtbCPF.Mask = "000.000.000-00";
            mtbCPF.Name = "mtbCPF";
            mtbCPF.Size = new Size(100, 23);
            mtbCPF.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 183);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 10;
            label6.Text = "CNPJ:";
            // 
            // mtbCNPJ
            // 
            mtbCNPJ.Location = new Point(318, 180);
            mtbCNPJ.Mask = "00.000.000/0000-00";
            mtbCNPJ.Name = "mtbCNPJ";
            mtbCNPJ.Size = new Size(100, 23);
            mtbCNPJ.TabIndex = 11;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 235);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(422, 235);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FormCadDoador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 270);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(mtbCNPJ);
            Controls.Add(label6);
            Controls.Add(mtbCPF);
            Controls.Add(label5);
            Controls.Add(clbPessoa);
            Controls.Add(label4);
            Controls.Add(mtbTelefone);
            Controls.Add(label3);
            Controls.Add(tbEndereco);
            Controls.Add(label2);
            Controls.Add(tbDoadorInstituicao);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadDoador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadDoador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbDoadorInstituicao;
        private Label label2;
        private TextBox tbEndereco;
        private Label label3;
        private MaskedTextBox mtbTelefone;
        private Label label4;
        private CheckedListBox clbPessoa;
        private Label label5;
        private MaskedTextBox mtbCPF;
        private Label label6;
        private MaskedTextBox mtbCNPJ;
        private Button btnSalvar;
        private Button btnLimpar;
    }
}