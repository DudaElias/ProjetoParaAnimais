using Microsoft.EntityFrameworkCore;
using ProjetoPraticaOficial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.DAO
{
    public class ItemPedidoDAO
    {
        public void Adiciona(ItemPedido c)
        {
            using (var context = new LoginContext())
            {
                c.Id = 0;
                context.ItemPedido.Add(c);
                context.SaveChanges();
            }
        }
        public IList<ItemPedido> Lista()
        {
            using (var contexto = new LoginContext())
            {
                return contexto.ItemPedido.ToList();
            }
        }
        public void Atualiza(ItemPedido ItemPedido)
        {
            using (var contexto = new LoginContext())
            {
                contexto.Entry(ItemPedido).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}