namespace ProjetoONG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            internoToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProfissionaisToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeÁreasToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeAssistidosToolStripMenuItem = new ToolStripMenuItem();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            dadosDaÁreaToolStripMenuItem = new ToolStripMenuItem();
            dadosDoProfissionalToolStripMenuItem = new ToolStripMenuItem();
            dadosDoAssistidoToolStripMenuItem = new ToolStripMenuItem();
            dadosDoDoadorToolStripMenuItem = new ToolStripMenuItem();
            doaçõesToolStripMenuItem = new ToolStripMenuItem();
            doadorToolStripMenuItem = new ToolStripMenuItem();
            doaçõesToolStripMenuItem1 = new ToolStripMenuItem();
            internoToolStripMenuItem1 = new ToolStripMenuItem();
            fianceiroToolStripMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            orçamentoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { internoToolStripMenuItem, consultaToolStripMenuItem, doaçõesToolStripMenuItem, internoToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // internoToolStripMenuItem
            // 
            internoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeProfissionaisToolStripMenuItem, cadastroDeÁreasToolStripMenuItem, cadastroDeAssistidosToolStripMenuItem });
            internoToolStripMenuItem.Name = "internoToolStripMenuItem";
            internoToolStripMenuItem.Size = new Size(71, 20);
            internoToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeProfissionaisToolStripMenuItem
            // 
            cadastroDeProfissionaisToolStripMenuItem.Name = "cadastroDeProfissionaisToolStripMenuItem";
            cadastroDeProfissionaisToolStripMenuItem.Size = new Size(206, 22);
            cadastroDeProfissionaisToolStripMenuItem.Text = "Cadastro de Profissionais";
            cadastroDeProfissionaisToolStripMenuItem.Click += cadastroDeProfissionaisToolStripMenuItem_Click;
            // 
            // cadastroDeÁreasToolStripMenuItem
            // 
            cadastroDeÁreasToolStripMenuItem.Name = "cadastroDeÁreasToolStripMenuItem";
            cadastroDeÁreasToolStripMenuItem.Size = new Size(206, 22);
            cadastroDeÁreasToolStripMenuItem.Text = "Cadastro de Áreas";
            cadastroDeÁreasToolStripMenuItem.Click += cadastroDeÁreasToolStripMenuItem_Click;
            // 
            // cadastroDeAssistidosToolStripMenuItem
            // 
            cadastroDeAssistidosToolStripMenuItem.Name = "cadastroDeAssistidosToolStripMenuItem";
            cadastroDeAssistidosToolStripMenuItem.Size = new Size(206, 22);
            cadastroDeAssistidosToolStripMenuItem.Text = "Cadastro de Assistidos";
            cadastroDeAssistidosToolStripMenuItem.Click += cadastroDeAssistidosToolStripMenuItem_Click;
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dadosDaÁreaToolStripMenuItem, dadosDoProfissionalToolStripMenuItem, dadosDoAssistidoToolStripMenuItem, dadosDoDoadorToolStripMenuItem });
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(71, 20);
            consultaToolStripMenuItem.Text = "Consultas";
            // 
            // dadosDaÁreaToolStripMenuItem
            // 
            dadosDaÁreaToolStripMenuItem.Name = "dadosDaÁreaToolStripMenuItem";
            dadosDaÁreaToolStripMenuItem.Size = new Size(188, 22);
            dadosDaÁreaToolStripMenuItem.Text = "Dados da Área";
            dadosDaÁreaToolStripMenuItem.Click += dadosDaÁreaToolStripMenuItem_Click;
            // 
            // dadosDoProfissionalToolStripMenuItem
            // 
            dadosDoProfissionalToolStripMenuItem.Name = "dadosDoProfissionalToolStripMenuItem";
            dadosDoProfissionalToolStripMenuItem.Size = new Size(188, 22);
            dadosDoProfissionalToolStripMenuItem.Text = "Dados do Profissional";
            dadosDoProfissionalToolStripMenuItem.Click += dadosDoProfissionalToolStripMenuItem_Click;
            // 
            // dadosDoAssistidoToolStripMenuItem
            // 
            dadosDoAssistidoToolStripMenuItem.Name = "dadosDoAssistidoToolStripMenuItem";
            dadosDoAssistidoToolStripMenuItem.Size = new Size(188, 22);
            dadosDoAssistidoToolStripMenuItem.Text = "Dados do Assistido";
            dadosDoAssistidoToolStripMenuItem.Click += dadosDoAssistidoToolStripMenuItem_Click;
            // 
            // dadosDoDoadorToolStripMenuItem
            // 
            dadosDoDoadorToolStripMenuItem.Name = "dadosDoDoadorToolStripMenuItem";
            dadosDoDoadorToolStripMenuItem.Size = new Size(188, 22);
            dadosDoDoadorToolStripMenuItem.Text = "Dados do Doador";
            dadosDoDoadorToolStripMenuItem.Click += dadosDoDoadorToolStripMenuItem_Click;
            // 
            // doaçõesToolStripMenuItem
            // 
            doaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doadorToolStripMenuItem, doaçõesToolStripMenuItem1 });
            doaçõesToolStripMenuItem.Name = "doaçõesToolStripMenuItem";
            doaçõesToolStripMenuItem.Size = new Size(64, 20);
            doaçõesToolStripMenuItem.Text = "Doações";
            // 
            // doadorToolStripMenuItem
            // 
            doadorToolStripMenuItem.Name = "doadorToolStripMenuItem";
            doadorToolStripMenuItem.Size = new Size(119, 22);
            doadorToolStripMenuItem.Text = "Doador";
            doadorToolStripMenuItem.Click += doadorToolStripMenuItem_Click;
            // 
            // doaçõesToolStripMenuItem1
            // 
            doaçõesToolStripMenuItem1.Name = "doaçõesToolStripMenuItem1";
            doaçõesToolStripMenuItem1.Size = new Size(119, 22);
            doaçõesToolStripMenuItem1.Text = "Doações";
            doaçõesToolStripMenuItem1.Click += doaçõesToolStripMenuItem1_Click;
            // 
            // internoToolStripMenuItem1
            // 
            internoToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { fianceiroToolStripMenuItem });
            internoToolStripMenuItem1.Name = "internoToolStripMenuItem1";
            internoToolStripMenuItem1.Size = new Size(57, 20);
            internoToolStripMenuItem1.Text = "Interno";
            // 
            // fianceiroToolStripMenuItem
            // 
            fianceiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despesasToolStripMenuItem, orçamentoToolStripMenuItem });
            fianceiroToolStripMenuItem.Name = "fianceiroToolStripMenuItem";
            fianceiroToolStripMenuItem.Size = new Size(180, 22);
            fianceiroToolStripMenuItem.Text = "Fianceiro";
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(180, 22);
            despesasToolStripMenuItem.Text = "Despesas";
            despesasToolStripMenuItem.Click += despesasToolStripMenuItem_Click;
            // 
            // orçamentoToolStripMenuItem
            // 
            orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            orçamentoToolStripMenuItem.Size = new Size(180, 22);
            orçamentoToolStripMenuItem.Text = "Orçamento";
            orçamentoToolStripMenuItem.Click += orçamentoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instituto Inspiração";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem internoToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProfissionaisToolStripMenuItem;
        private ToolStripMenuItem cadastroDeÁreasToolStripMenuItem;
        private ToolStripMenuItem cadastroDeAssistidosToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem dadosDaÁreaToolStripMenuItem;
        private ToolStripMenuItem dadosDoProfissionalToolStripMenuItem;
        private ToolStripMenuItem dadosDoAssistidoToolStripMenuItem;
        private ToolStripMenuItem doaçõesToolStripMenuItem;
        private ToolStripMenuItem doadorToolStripMenuItem;
        private ToolStripMenuItem dadosDoDoadorToolStripMenuItem;
        private ToolStripMenuItem doaçõesToolStripMenuItem1;
        private ToolStripMenuItem internoToolStripMenuItem1;
        private ToolStripMenuItem fianceiroToolStripMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem orçamentoToolStripMenuItem;
    }
}
