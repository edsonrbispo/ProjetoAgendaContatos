using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaContatos.DAO;
using AgendaContatos.Model;

namespace AgendaContatos.Controller
{
    public class ContatoController
    {
        public List<Contatos> ListarContatos() {
            return ContatosDAO.Listar();
        }
    }
}
