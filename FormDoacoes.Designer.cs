namespace ProjetoONG
{
    partial class FormDoacoes
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
            tbNomeDoador = new TextBox();
            btnBuscar = new Button();
            label3 = new Label();
            dgvDadosDoador = new DataGridView();
            label4 = new Label();
            clbTipoDoacao = new CheckedListBox();
            label5 = new Label();
            tbValor = new TextBox();
            label6 = new Label();
            tbItemDoado = new TextBox();
            label7 = new Label();
            clbFrequencia = new CheckedListBox(); // Corrigido: adicionado a instância
            label8 = new Label();
            cbFrequenciaDoacoes = new ComboBox();
            btnSalvar = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDadosDoador).BeginInit();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Espécies de Donativos";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome do doador:";
            //
            // tbNomeDoador
            //
            tbNomeDoador.Location = new Point(119, 42);
            tbNomeDoador.Name = "tbNomeDoador";
            tbNomeDoador.Size = new Size(273, 23);
            tbNomeDoador.TabIndex = 2;
            //
            // btnBuscar
            //
            btnBuscar.Location = new Point(398, 42);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += new System.EventHandler(btnBuscar_Click);
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(12, 93);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 4;
            label3.Text = "Dados do doador:";
            //
            // dgvDadosDoador
            //
            dgvDadosDoador.AllowUserToOrderColumns = true;
            dgvDadosDoador.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDadosDoador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDadosDoador.Location = new Point(119, 93);
            dgvDadosDoador.Name = "dgvDadosDoador";
            dgvDadosDoador.RowTemplate.Height = 25;
            dgvDadosDoador.Size = new Size(739, 62);
            dgvDadosDoador.TabIndex = 5;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 6;
            label4.Text = "Tipo de doação:";
            //
            // clbTipoDoacao
            //
            clbTipoDoacao.FormattingEnabled = true;
            clbTipoDoacao.Items.AddRange(new object[] { "Monetária", "Não monetária" });
            clbTipoDoacao.Location = new Point(119, 187);
            clbTipoDoacao.Name = "clbTipoDoacao";
            clbTipoDoacao.Size = new Size(120, 40);
            clbTipoDoacao.TabIndex = 7;
            //
            // label5
            //
            label5.AutoSize = true;
            label5.Location = new Point(473, 187);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "Valor:";
            //
            // tbValor
            //
            tbValor.Location = new Point(519, 184);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 9;
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Location = new Point(633, 187);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 10;
            label6.Text = "Item(s) doado(s)";
            //
            // tbItemDoado
            //
            tbItemDoado.Location = new Point(736, 184);
            tbItemDoado.Name = "tbItemDoado";
            tbItemDoado.Size = new Size(122, 23);
            tbItemDoado.TabIndex = 11;
            //
            // label7
            //
            label7.AutoSize = true;
            label7.Location = new Point(245, 187);
            label7.Name = "label7";
            label7.Size = new Size(154, 15);
            label7.TabIndex = 12;
            label7.Text = "Há frequência nas doações?";
            //
            // clbFrequencia
            //
            clbFrequencia.FormattingEnabled = true;
            clbFrequencia.Items.AddRange(new object[] { "Sim", "Não" });
            clbFrequencia.Location = new Point(405, 187);
            clbFrequencia.Name = "clbFrequencia";
            clbFrequencia.Size = new Size(62, 40);
            clbFrequencia.TabIndex = 13;
            //
            // label8
            //
            label8.AutoSize = true;
            label8.Location = new Point(12, 242);
            label8.Name = "label8";
            label8.Size = new Size(131, 15);
            label8.TabIndex = 14;
            label8.Text = "Frequência de doações:";
            //
            // cbFrequenciaDoacoes
            //
            cbFrequenciaDoacoes.FormattingEnabled = true;
            cbFrequenciaDoacoes.Items.AddRange(new object[] { "Anual", "Mensal", "Semanal" });
            cbFrequenciaDoacoes.Location = new Point(149, 239);
            cbFrequenciaDoacoes.Name = "cbFrequenciaDoacoes";
            cbFrequenciaDoacoes.Size = new Size(121, 23);
            cbFrequenciaDoacoes.TabIndex = 15;
            //
            // btnSalvar
            //
            btnSalvar.Location = new Point(519, 241);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += new System.EventHandler(btnSalvar_Click);
            //
            // btnLimpar
            //
            btnLimpar.Location = new Point(600, 241);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += new System.EventHandler(btnLimpar_Click);
            //
            // FormDoacoes
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 276);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(cbFrequenciaDoacoes);
            Controls.Add(label8);
            Controls.Add(clbFrequencia);
            Controls.Add(label7);
            Controls.Add(tbItemDoado);
            Controls.Add(label6);
            Controls.Add(tbValor);
            Controls.Add(label5);
            Controls.Add(clbTipoDoacao);
            Controls.Add(label4);
            Controls.Add(dgvDadosDoador);
            Controls.Add(label3);
            Controls.Add(btnBuscar);
            Controls.Add(tbNomeDoador);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDoacoes";
            Text = "FormDoacoes";
            ((System.ComponentModel.ISupportInitialize)dgvDadosDoador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbNomeDoador;
        private Button btnBuscar;
        private Label label3;
        private DataGridView dgvDadosDoador;
        private Label label4;
        private CheckedListBox clbTipoDoacao;
        private Label label5;
        private TextBox tbValor;
        private Label label6;
        private TextBox tbItemDoado;
        private Label label7;
        private CheckedListBox clbFrequencia; // Corrigido: adicionado a instância
        private Label label8;
        private ComboBox cbFrequenciaDoacoes;
        private Button btnSalvar;
        private Button btnLimpar;
    }
}
