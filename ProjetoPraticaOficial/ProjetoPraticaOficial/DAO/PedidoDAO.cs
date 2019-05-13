using Microsoft.EntityFrameworkCore;
using ProjetoPraticaOficial.Models;
using System;
using System.Collections.Generic;
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
    }
}