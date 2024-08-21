namespace ProjetoONG
{
    partial class FormEscolhaDoador
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
            cbNomeDoador = new ComboBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cbNomeDoador
            // 
            cbNomeDoador.FormattingEnabled = true;
            cbNomeDoador.Location = new Point(12, 22);
            cbNomeDoador.Name = "cbNomeDoador";
            cbNomeDoador.Size = new Size(369, 23);
            cbNomeDoador.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(387, 22);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(49, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(442, 22);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormEscolhaDoador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 65);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cbNomeDoador);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEscolhaDoador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEscolhaDoador";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbNomeDoador;
        private Button btnOk;
        private Button btnCancel;
    }
}