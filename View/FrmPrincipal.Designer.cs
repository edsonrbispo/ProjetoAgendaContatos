namespace AgendaContatos
{
    partial class FrmPrincipal
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
            mnuMenuPrincipal = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            contatosToolStripMenuItem = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnConexao = new Button();
            mnuMenuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMenuPrincipal
            // 
            mnuMenuPrincipal.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, sistemaToolStripMenuItem });
            mnuMenuPrincipal.Location = new Point(0, 0);
            mnuMenuPrincipal.Name = "mnuMenuPrincipal";
            mnuMenuPrincipal.Size = new Size(800, 24);
            mnuMenuPrincipal.TabIndex = 0;
            mnuMenuPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatosToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(66, 20);
            cadastrosToolStripMenuItem.Text = "Cadastro";
            // 
            // contatosToolStripMenuItem
            // 
            contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
            contatosToolStripMenuItem.Size = new Size(180, 22);
            contatosToolStripMenuItem.Text = "Contatos";
            contatosToolStripMenuItem.Click += contatosToolStripMenuItem_Click;
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // btnConexao
            // 
            btnConexao.Location = new Point(642, 415);
            btnConexao.Name = "btnConexao";
            btnConexao.Size = new Size(146, 23);
            btnConexao.TabIndex = 1;
            btnConexao.Text = "Teste Conexão";
            btnConexao.UseVisualStyleBackColor = true;
            btnConexao.Click += btnConexao_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConexao);
            Controls.Add(mnuMenuPrincipal);
            MainMenuStrip = mnuMenuPrincipal;
            Name = "FrmPrincipal";
            Text = "Sistema de Agenda de Contatos";
            mnuMenuPrincipal.ResumeLayout(false);
            mnuMenuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMenuPrincipal;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem contatosToolStripMenuItem;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button btnConexao;
    }
}
