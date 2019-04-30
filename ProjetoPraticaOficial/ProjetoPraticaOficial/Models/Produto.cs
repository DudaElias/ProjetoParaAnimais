using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public int CodLoja { get; set; }

        public string Imagem { get; set; }
        public int CodFiltro { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}