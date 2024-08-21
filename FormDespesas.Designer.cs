namespace ProjetoONG
{
    partial class FormDespesas
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
            tbContasDeConsumo = new TextBox();
            label3 = new Label();
            tbSalario = new TextBox();
            label4 = new Label();
            tbFornecedores = new TextBox();
            label5 = new Label();
            tbOutros = new TextBox();
            tbDataHora = new TextBox();
            btnAdDespesa = new Button();
            btnLimpar = new Button();
            btnBuscarDespesa = new Button();
            dgvInfoDespesa = new DataGridView();
            btnEditarDespesa = new Button();
            btnExcluirDespesa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInfoDespesa).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipos de Despesas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 1;
            label2.Text = "Contas de consumo:";
            // 
            // tbContasDeConsumo
            // 
            tbContasDeConsumo.Location = new Point(134, 38);
            tbContasDeConsumo.Name = "tbContasDeConsumo";
            tbContasDeConsumo.Size = new Size(100, 23);
            tbContasDeConsumo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 41);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Salário:";
            // 
            // tbSalario
            // 
            tbSalario.Location = new Point(291, 38);
            tbSalario.Name = "tbSalario";
            tbSalario.Size = new Size(100, 23);
            tbSalario.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 74);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 5;
            label4.Text = "Forncedores:";
            // 
            // tbFornecedores
            // 
            tbFornecedores.Location = new Point(134, 71);
            tbFornecedores.Name = "tbFornecedores";
            tbFornecedores.Size = new Size(100, 23);
            tbFornecedores.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 74);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 7;
            label5.Text = "Outros:";
            // 
            // tbOutros
            // 
            tbOutros.Location = new Point(292, 71);
            tbOutros.Name = "tbOutros";
            tbOutros.Size = new Size(100, 23);
            tbOutros.TabIndex = 8;
            // 
            // tbDataHora
            // 
            tbDataHora.Location = new Point(291, 9);
            tbDataHora.Name = "tbDataHora";
            tbDataHora.ReadOnly = true;
            tbDataHora.Size = new Size(100, 23);
            tbDataHora.TabIndex = 9;
            // 
            // btnAdDespesa
            // 
            btnAdDespesa.Location = new Point(12, 113);
            btnAdDespesa.Name = "btnAdDespesa";
            btnAdDespesa.Size = new Size(116, 23);
            btnAdDespesa.TabIndex = 10;
            btnAdDespesa.Text = "Adicionar Despesa";
            btnAdDespesa.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(159, 113);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarDespesa
            // 
            btnBuscarDespesa.Location = new Point(284, 113);
            btnBuscarDespesa.Name = "btnBuscarDespesa";
            btnBuscarDespesa.Size = new Size(107, 23);
            btnBuscarDespesa.TabIndex = 12;
            btnBuscarDespesa.Text = "Buacar Despesa";
            btnBuscarDespesa.UseVisualStyleBackColor = true;
            // 
            // dgvInfoDespesa
            // 
            dgvInfoDespesa.AllowUserToDeleteRows = false;
            dgvInfoDespesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInfoDespesa.Location = new Point(11, 142);
            dgvInfoDespesa.Name = "dgvInfoDespesa";
            dgvInfoDespesa.ReadOnly = true;
            dgvInfoDespesa.RowTemplate.Height = 25;
            dgvInfoDespesa.Size = new Size(380, 70);
            dgvInfoDespesa.TabIndex = 13;
            // 
            // btnEditarDespesa
            // 
            btnEditarDespesa.Location = new Point(12, 218);
            btnEditarDespesa.Name = "btnEditarDespesa";
            btnEditarDespesa.Size = new Size(116, 23);
            btnEditarDespesa.TabIndex = 14;
            btnEditarDespesa.Text = "Editar Despesa";
            btnEditarDespesa.UseVisualStyleBackColor = true;
            // 
            // btnExcluirDespesa
            // 
            btnExcluirDespesa.Location = new Point(284, 218);
            btnExcluirDespesa.Name = "btnExcluirDespesa";
            btnExcluirDespesa.Size = new Size(107, 23);
            btnExcluirDespesa.TabIndex = 15;
            btnExcluirDespesa.Text = "Excluir Despesa";
            btnExcluirDespesa.UseVisualStyleBackColor = true;
            // 
            // FormDespesas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 249);
            Controls.Add(btnExcluirDespesa);
            Controls.Add(btnEditarDespesa);
            Controls.Add(dgvInfoDespesa);
            Controls.Add(btnBuscarDespesa);
            Controls.Add(btnLimpar);
            Controls.Add(btnAdDespesa);
            Controls.Add(tbDataHora);
            Controls.Add(tbOutros);
            Controls.Add(label5);
            Controls.Add(tbFornecedores);
            Controls.Add(label4);
            Controls.Add(tbSalario);
            Controls.Add(label3);
            Controls.Add(tbContasDeConsumo);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDespesas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Despesas";
            ((System.ComponentModel.ISupportInitialize)dgvInfoDespesa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbContasDeConsumo;
        private Label label3;
        private TextBox tbSalario;
        private Label label4;
        private TextBox tbFornecedores;
        private Label label5;
        private TextBox tbOutros;
        private TextBox tbDataHora;
        private Button btnAdDespesa;
        private Button btnLimpar;
        private Button btnBuscarDespesa;
        private DataGridView dgvInfoDespesa;
        private Button btnEditarDespesa;
        private Button btnExcluirDespesa;
    }
}