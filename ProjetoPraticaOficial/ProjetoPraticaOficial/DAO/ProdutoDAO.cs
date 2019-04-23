using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoPraticaOficial.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoPraticaOficial.DAO
{
    public class ProdutoDAO
    {
        public void Adiciona(Produto c)
        {
            using (var context = new LoginContext())
            {
                c.Id = 0;
                c.CodLoja = 2;
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
    }
}