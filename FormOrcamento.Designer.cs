namespace ProjetoONG
{
    partial class FormOrcamento
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
            tbAdReceita = new TextBox();
            btnAdReceita = new Button();
            btnLimpar = new Button();
            label2 = new Label();
            lbTotAtivos = new Label();
            label3 = new Label();
            lbTotDespesas = new Label();
            label4 = new Label();
            lbBalAtual = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Adicionar receita:";
            // 
            // tbAdReceita
            // 
            tbAdReceita.Location = new Point(117, 9);
            tbAdReceita.Name = "tbAdReceita";
            tbAdReceita.Size = new Size(108, 23);
            tbAdReceita.TabIndex = 1;
            // 
            // btnAdReceita
            // 
            btnAdReceita.Location = new Point(242, 9);
            btnAdReceita.Name = "btnAdReceita";
            btnAdReceita.Size = new Size(75, 23);
            btnAdReceita.TabIndex = 2;
            btnAdReceita.Text = "Incluir";
            btnAdReceita.UseVisualStyleBackColor = true;
            btnAdReceita.Click += btnAdReceita_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(323, 9);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 4;
            label2.Text = "Total de ativos:";
            // 
            // lbTotAtivos
            // 
            lbTotAtivos.AutoSize = true;
            lbTotAtivos.Location = new Point(117, 56);
            lbTotAtivos.Name = "lbTotAtivos";
            lbTotAtivos.Size = new Size(52, 15);
            lbTotAtivos.TabIndex = 5;
            lbTotAtivos.Text = "_________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 56);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 6;
            label3.Text = "Total de despesas:";
            // 
            // lbTotDespesas
            // 
            lbTotDespesas.AutoSize = true;
            lbTotDespesas.Location = new Point(349, 56);
            lbTotDespesas.Name = "lbTotDespesas";
            lbTotDespesas.Size = new Size(52, 15);
            lbTotDespesas.TabIndex = 7;
            lbTotDespesas.Text = "_________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 8;
            label4.Text = "Balancete atual:";
            // 
            // lbBalAtual
            // 
            lbBalAtual.AutoSize = true;
            lbBalAtual.Location = new Point(117, 99);
            lbBalAtual.Name = "lbBalAtual";
            lbBalAtual.Size = new Size(52, 15);
            lbBalAtual.TabIndex = 9;
            lbBalAtual.Text = "_________";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(242, 99);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(156, 23);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar Alterações";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 143);
            Controls.Add(btnSalvar);
            Controls.Add(lbBalAtual);
            Controls.Add(label4);
            Controls.Add(lbTotDespesas);
            Controls.Add(label3);
            Controls.Add(lbTotAtivos);
            Controls.Add(label2);
            Controls.Add(btnLimpar);
            Controls.Add(btnAdReceita);
            Controls.Add(tbAdReceita);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOrcamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orçamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbAdReceita;
        private Button btnAdReceita;
        private Button btnLimpar;
        private Label label2;
        private Label lbTotAtivos;
        private Label label3;
        private Label lbTotDespesas;
        private Label label4;
        private Label lbBalAtual;
        private Button btnSalvar;
    }
}