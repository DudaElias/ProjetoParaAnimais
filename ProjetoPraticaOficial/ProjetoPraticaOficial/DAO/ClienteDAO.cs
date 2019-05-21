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
                c.Id = 0;
                context.Cliente.Add(c);
                context.SaveChanges();
            }
        }
        public Cliente BuscaPorNome(string nome)
        {
            using (var contexto = new LoginContext())
            {
                return contexto.Cliente
                .Where(p => p.Nome == nome)
                .FirstOrDefault();
            }
        }
        public IList<Cliente> Lista()
        {
            using (var contexto = new LoginContext())
            {
                return contexto.Cliente.ToList();
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