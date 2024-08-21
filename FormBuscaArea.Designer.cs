namespace ProjetoONG
{
    partial class FormBuscaArea
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
            btnLimpar = new Button();
            btnBuscar = new Button();
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
            tbNomeArea.Location = new Point(104, 6);
            tbNomeArea.Name = "tbNomeArea";
            tbNomeArea.Size = new Size(248, 23);
            tbNomeArea.TabIndex = 1;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 57);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 0;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(287, 57);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FormBuscaArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 92);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpar);
            Controls.Add(tbNomeArea);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBuscaArea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Área";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNomeArea;
        private Button btnLimpar;
        private Button btnBuscar;
    }
}