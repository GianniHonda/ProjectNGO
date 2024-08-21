namespace ProjetoONG
{
    partial class FormBuscaAssistido
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
            tbNomeAssistido = new TextBox();
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
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Assistido:";
            // 
            // tbNomeAssistido
            // 
            tbNomeAssistido.Location = new Point(128, 9);
            tbNomeAssistido.Name = "tbNomeAssistido";
            tbNomeAssistido.Size = new Size(327, 23);
            tbNomeAssistido.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 47);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(380, 47);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // FormBuscaAssistido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 82);
            Controls.Add(btnLimpar);
            Controls.Add(btnBuscar);
            Controls.Add(tbNomeAssistido);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBuscaAssistido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBuscaAssistido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNomeAssistido;
        private Button btnBuscar;
        private Button btnLimpar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}