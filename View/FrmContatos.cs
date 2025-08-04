using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaContatos.Controller;
using AgendaContatos.Model;

namespace AgendaContatos.View
{
    public partial class FrmContatos : Form
    {
        private readonly ContatoController contatoController = new();
        public FrmContatos()
        {
            InitializeComponent();
        }

        private void FrmContatos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
            lblNome.Focus();
        }

        private void AtualizarGrid()
        {

            dgvListaContatos.DataSource = contatoController.ListarContatos();


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtObservacao.ReadOnly = false;
            txtNome.Focus();
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome é Obrigatório.", "Atenção");
                return;
            }

            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (string.IsNullOrWhiteSpace(txtTelefone.Text) && string.IsNullOrWhiteSpace(txtCelular.Text))
            {
                MessageBox.Show("Preencha pelo menos Telefone ou Celular", "Atenção");
                return;
            }

            txtTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            txtCelular.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            var contato = new Contatos
            {
                Id = string.IsNullOrWhiteSpace(txtCodigo.Text) ? 0 : int.Parse(txtCodigo.Text),
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text,
                Observacao = txtObservacao.Text
            };

            try
            {
                contatoController.SalvarContato(contato);

                MessageBox.Show("Contato salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                AtualizarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar contato: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtObservacao.Clear();
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtCelular.ReadOnly = true;
            txtObservacao.ReadOnly = true;
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvListaContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var contatoSelecionado = dgvListaContatos.Rows[e.RowIndex].DataBoundItem as Contatos;

                if (contatoSelecionado != null)
                {
                    txtCodigo.Text = contatoSelecionado.Id.ToString();
                    txtNome.Text = contatoSelecionado.Nome;
                    txtEmail.Text = contatoSelecionado.Email;
                    txtTelefone.Text = contatoSelecionado.Telefone;
                    txtCelular.Text = contatoSelecionado.Celular;
                    txtObservacao.Text = contatoSelecionado.Observacao;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnNovo.Enabled = false;
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtCelular.ReadOnly = false;
            txtObservacao.ReadOnly = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            txtNome.Focus();
        }
    }
}
