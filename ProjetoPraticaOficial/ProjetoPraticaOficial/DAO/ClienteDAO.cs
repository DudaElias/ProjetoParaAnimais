using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using ProjetoPraticaOficial.Models;

namespace ProjetoPraticaOficial.DAO
{
    public class ClienteDAO
    {
        public void Adiciona(Cliente c)
        {
            using (var context = new LoginContext())
            {
                context.Cliente.Add(c);
                context.SaveChanges();
            }
        }
        public IList<Cliente> Lista()
        {
            using (var contexto = new LoginContext())
            {
                return contexto.Cliente.ToList();
            }
        }
        public Cliente BuscaPorRa(int cod)
         {
             using (var contexto = new LoginContext())
             {
                 return contexto.Cliente
                 .Where(p => p.codCliente == cod)
                .FirstOrDefault();
             }
        }
        public void Atualiza(Cliente Cliente)
        {
            using (var contexto = new LoginContext())
            {
                contexto.Entry(Cliente).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}