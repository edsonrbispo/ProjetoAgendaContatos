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

        }
    }
}
