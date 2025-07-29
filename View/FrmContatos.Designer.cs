namespace AgendaContatos.View
{
    partial class FrmContatos
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTelefone = new Label();
            txtTelefone = new MaskedTextBox();
            lblCelular = new Label();
            txtCelular = new MaskedTextBox();
            lblObservacao = new Label();
            txtObservacao = new TextBox();
            btnNovo = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            grbListaContatos = new GroupBox();
            dgvListaContatos = new DataGridView();
            grbListaContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaContatos).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(15, 15);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(15, 33);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(143, 14);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(143, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(272, 23);
            txtNome.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(438, 10);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(438, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(340, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(16, 69);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(16, 87);
            txtTelefone.Mask = "(99) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(181, 23);
            txtTelefone.TabIndex = 7;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(223, 70);
            lblCelular.Name = "lblCelular";
            lblCelular.RightToLeft = RightToLeft.No;
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 8;
            lblCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(223, 87);
            txtCelular.Mask = "(99) 00000-0000";
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(200, 23);
            txtCelular.TabIndex = 9;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(440, 69);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(69, 15);
            lblObservacao.TabIndex = 10;
            lblObservacao.Text = "Observação";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(440, 87);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(338, 66);
            txtObservacao.TabIndex = 11;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(17, 130);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 12;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(113, 130);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(209, 130);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(305, 130);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // grbListaContatos
            // 
            grbListaContatos.Controls.Add(dgvListaContatos);
            grbListaContatos.Location = new Point(15, 191);
            grbListaContatos.Name = "grbListaContatos";
            grbListaContatos.Size = new Size(761, 298);
            grbListaContatos.TabIndex = 16;
            grbListaContatos.TabStop = false;
            grbListaContatos.Text = "Lista de Contatos";
            // 
            // dgvListaContatos
            // 
            dgvListaContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaContatos.Location = new Point(14, 22);
            dgvListaContatos.Name = "dgvListaContatos";
            dgvListaContatos.Size = new Size(733, 261);
            dgvListaContatos.TabIndex = 0;
            // 
            // FrmContatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(grbListaContatos);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(txtObservacao);
            Controls.Add(lblObservacao);
            Controls.Add(txtCelular);
            Controls.Add(lblCelular);
            Controls.Add(txtTelefone);
            Controls.Add(lblTelefone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Name = "FrmContatos";
            Text = "Cadastro de Contatos";
            grbListaContatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaContatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTelefone;
        private MaskedTextBox txtTelefone;
        private Label lblCelular;
        private MaskedTextBox txtCelular;
        private Label lblObservacao;
        private TextBox txtObservacao;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
        private GroupBox grbListaContatos;
        private DataGridView dgvListaContatos;
    }
}