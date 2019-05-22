using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.Models
{
    public class PedidoFeito
    {
        string nome;
        int quantidade;
        DateTime dataEntrega;
        string endereco;

        public string Nome { get => nome; set => nome = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public DateTime DataEntrega { get => dataEntrega; set => dataEntrega = value; }
        public string Endereco { get => endereco; set => endereco = value; }
    }
}