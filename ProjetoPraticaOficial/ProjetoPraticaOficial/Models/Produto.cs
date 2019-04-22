using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodLoja { get; set; }
        public string CodFiltro { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
    }
}