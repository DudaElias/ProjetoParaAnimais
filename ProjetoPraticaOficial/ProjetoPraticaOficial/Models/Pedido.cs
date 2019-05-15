using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int CodCliente { get; set; }
        public int CodPedido { get; set; }
        public DateTime DataEntrega { get; set; }
        public decimal PrecoEntrega { get; set; }
        public string Endereco { get; set; }

    }
}