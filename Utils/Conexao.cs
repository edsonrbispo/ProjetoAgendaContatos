using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AgendaContatos.Utils
{
    public static class Conexao
    {

        private static string stringConexao = @"Data Source=MAR0625636W10-1;Initial Catalog=agenda_contatos;
                                User ID=sa;Password=senac2025;TrustServerCertificate=True;
                                Integrated Security=false";
        public static SqlConnection ObterConexao()
        {
           return new SqlConnection(stringConexao);           
        }

    }
}
