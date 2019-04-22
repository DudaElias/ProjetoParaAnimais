using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using ProjetoPraticaOficial.Models;

namespace ProjetoPraticaOficial.DAO
{
    public class FiltroDAO
    {
        public void Adiciona(Filtro c)
        {
            using (var context = new LoginContext())
            {
                c.Id = 0;
                context.Filtro.Add(c);
                context.SaveChanges();
            }
        }
        public Filtro BuscaPorNome(string nome)
        {
            using (var contexto = new LoginContext())
            {
                return contexto.Filtro
                .Where(p => p.Animal == nome)
                .FirstOrDefault();
            }
        }
        public IList<Filtro> Lista()
        {
            using (var contexto = new LoginContext())
            {
                return contexto.Filtro.ToList();
            }
        }
        public void Atualiza(Filtro Filtro)
        {
            using (var contexto = new LoginContext())
            {
                contexto.Entry(Filtro).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
    }
}