using AgendaContatos.Utils;
using AgendaContatos.View;
using Microsoft.Data.SqlClient;

namespace AgendaContatos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConexao_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = Conexao.ObterConexao();
                conn.Open();
                MessageBox.Show("Conexão realiza com sucesso!", "Sucesso",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar: {ex.Message}", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmContatos frmContatos = new FrmContatos();
            frmContatos.ShowDialog();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
