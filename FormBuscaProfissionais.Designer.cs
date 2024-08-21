namespace ProjetoONG
{
    partial class FormBuscaProfissionais
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
            tbNomeProfissional = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            btnLimpar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // tbNomeProfissional
            // 
            tbNomeProfissional.Location = new Point(142, 9);
            tbNomeProfissional.Name = "tbNomeProfissional";
            tbNomeProfissional.Size = new Size(284, 23);
            tbNomeProfissional.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome do Profissional:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 58);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(351, 58);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FormBuscaProfissionais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 93);
            Controls.Add(btnLimpar);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(tbNomeProfissional);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBuscaProfissionais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBuscaProfissionais";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNomeProfissional;
        private Label label1;
        private Button btnBuscar;
        private Button btnLimpar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}