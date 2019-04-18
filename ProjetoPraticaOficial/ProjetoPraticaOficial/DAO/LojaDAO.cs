using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using ProjetoPraticaOficial.Models;

namespace ProjetoPraticaOficial.DAO
{
    public class LojaDAO
    {
        public void Adiciona(Loja c)
        {
            using (var context = new LoginContext())
            {
                c.Id = 0;
                context.Loja.Add(c);
                context.SaveChanges();
            }
        }
        public Loja BuscaPorNome(string nome)
        {
            using (var contexto = new LoginContext())
            {
                return contexto.Loja
                .Where(p => p.Nome == nome)
                .FirstOrDefault();
            }
        }
        public IList<Loja> Lista()
        {
            using (var contexto = new LoginContext())
            {
                return contexto.Loja.ToList();
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
    }
}