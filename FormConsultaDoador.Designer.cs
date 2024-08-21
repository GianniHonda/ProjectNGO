namespace ProjetoONG
{
    partial class FormConsultaDoador
    {
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbNomeDoador.Text = string.Empty;
        }

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
            tbNomeDoador = new TextBox();
            btnBuscar = new Button();
            btnLimpar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome doador:";
            // 
            // tbNomeDoador
            // 
            tbNomeDoador.Location = new Point(102, 6);
            tbNomeDoador.Name = "tbNomeDoador";
            tbNomeDoador.Size = new Size(326, 23);
            tbNomeDoador.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 61);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(353, 61);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FormConsultaDoador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 90);
            Controls.Add(btnLimpar);
            Controls.Add(btnBuscar);
            Controls.Add(tbNomeDoador);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaDoador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormConsultaDoador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNomeDoador;
        private Button btnBuscar;
        private Button btnLimpar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}