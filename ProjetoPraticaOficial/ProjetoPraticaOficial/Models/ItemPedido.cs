using Microsoft.EntityFrameworkCore;
using ProjetoPraticaOficial.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public int CodProduto { get; set; }
        public int Quantidade { get; set; }
    }
}