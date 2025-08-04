using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaContatos.Model;
using AgendaContatos.Utils;
using Microsoft.Data.SqlClient;

namespace AgendaContatos.DAO
{
    public static class ContatosDAO
    {
        public static List<Contatos> Listar() 
        { 
            var lista = new List<Contatos>();
            using var conn = Conexao.ObterConexao();
            conn.Open();
            var sql = "SELECT * FROM contatos";
            using var cmd = new SqlCommand(sql, conn);
            using var listaDados = cmd.ExecuteReader();
            while (listaDados.Read()) 
            { 
                lista.Add(new Contatos
                {
                    Id = (int)listaDados["id"],
                    Nome = listaDados["nome"].ToString(),
                    Email = listaDados["email"].ToString(),
                    Telefone = listaDados["telefone"].ToString(),
                    Celular = listaDados["celular"].ToString(),
                    Observacao = listaDados["observacao"].ToString()
                });
            }
            return lista;
        }

        public static void Inserir(Contatos contato)
        {
            using var conn = Conexao.ObterConexao();
            conn.Open();
            var sql = "INSERT INTO contatos (nome, email, telefone, celular,            observacao) VALUES (@nome, @email, @telefone, @celular,            @observacao)";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@telefone", contato.Telefone ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@celular", contato.Celular ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@observacao", contato.Observacao ?? (object)DBNull.Value);
            cmd.ExecuteNonQuery();

        }

        public static void Atualizar(Contatos contato)
        {
            using var conn = Conexao.ObterConexao();
            conn.Open();
            var sql = "UPDATE contatos SET nome=@nome, email=@email, telefone=@telefone, celular=@celular, observacao=@observacao WHERE id=@id";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", contato.Id);
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@telefone", contato.Telefone ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@celular", contato.Celular ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@observacao", contato.Observacao ?? (object)DBNull.Value);
            cmd.ExecuteNonQuery();
        }

    }
}
