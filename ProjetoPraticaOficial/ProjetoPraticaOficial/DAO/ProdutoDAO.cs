using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoPraticaOficial.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace ProjetoPraticaOficial.DAO
{
    public class ProdutoDAO
    {
        public void Adiciona(Produto c)
        {
            using (var context = new LoginContext())
            {
                c.Id = 0;
                context.Produto.Add(c);
                context.SaveChanges();
            }
        }
        public Produto BuscaPorNome(string nome)
        {
            using (var contexto = new LoginContext())
            {
                return contexto.Produto
                .Where(p => p.Nome == nome)
                .FirstOrDefault();
            }
        }
        public Produto BuscaPorId(int id)
        {
            using (var contexto = new LoginContext())
            {
                return contexto.Produto
                .Where(p => p.Id == id)
                .FirstOrDefault();
            }
        }
        public IList<Produto> Lista()
        {
            using (var contexto = new LoginContext())
            {
                return contexto.Produto.ToList();
            }
        }
        public void Atualiza(Loja Loja)
        {
            using (var contexto = new LoginContext())
            {
                Loja.Id = 0;
                contexto.Entry(Loja).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public List<Produto> Produtos(int id)
        {
            List<Produto> lista = new List<Produto>();
            Produto pr = null;
            using (var conn = new SqlConnection("Data Source=regulus.cotuca.unicamp.br;Initial Catalog='PR118343'; User ID ='PR118343'; Password ='PR118343'"))
            {
                string sql = "select * from Produto where codFiltro = @Id)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            pr = new Produto();
                            pr.Id = (int)reader["id"];
                            pr.CodLoja = (int)reader["codLoja"];
                            pr.CodFiltro = (int)reader["codFiltro"];
                            pr.Imagem = reader["imagem"].ToString();
                            pr.Nome = reader["nome"].ToString();
                            pr.Descricao = reader["descricao"].ToString();
                            pr.Preco = (decimal)reader["preco"];
                            lista.Add(pr);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return lista;
        }
    }
}