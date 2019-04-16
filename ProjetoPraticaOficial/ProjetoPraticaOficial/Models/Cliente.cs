using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.Models
{
    public class Cliente
    {
        public Cliente(int i, string n, string e, string c, string s, string cel)
        {
            codCliente = i;
            nome = n;
            email = e;
            cpf = c;
            senha = s;
            telefone = cel;
        }
        public int codCliente { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string senha { get; set; }
        public string telefone { get; set; }
    }
}