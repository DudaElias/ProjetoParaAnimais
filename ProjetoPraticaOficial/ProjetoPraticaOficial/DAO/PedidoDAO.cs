using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ProjetoPraticaOficial.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.DAO
{
    public class PedidoDAO
    {
        public void Adiciona(Pedido c)
        {
            using (var context = new LoginContext())
            {
                c.Id = 0;
                context.Pedido.Add(c);
                context.SaveChanges();
            }
        }
        public IList<Pedido> Lista()
        {
            using (var contexto = new LoginContext())
            {
                return contexto.Pedido.ToList();
            }
        }
        public void Atualiza(Pedido Pedido)
        {
            using (var contexto = new LoginContext())
            {
                contexto.Entry(Pedido).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public List<Pedido> Pedidos(int id)
        {

            List<Pedido> list = new List<Pedido>();
            Pedido p = null;
            using (var conn = new SqlConnection("Data Source=regulus.cotuca.unicamp.br;Initial Catalog='PR118343'; User ID ='PR118343'; Password ='PR118343'"))
            {
                string sql = "select * from Pedido where codPedido in (select id from ItemPedido where codProduto in (select id from Produto where codLoja = @Id))";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                try
                {
                    conn.Open();
                    using (var reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            p = new Pedido();
                            p.Id = (int)reader["id"];
                            p.CodCliente = (int)reader["codCliente"];
                            p.CodPedido = (int)reader["codPedido"];
                            p.DataEntrega = (DateTime)reader["dataEntrega"];
                            p.Endereco = reader["endereco"].ToString();
                            p.DataPedido = (DateTime)reader["dataPedido"];
                            p.PrecoEntrega = (decimal)reader["precoEntrega"];
                            list.Add(p);
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return list;
        }
    }
}