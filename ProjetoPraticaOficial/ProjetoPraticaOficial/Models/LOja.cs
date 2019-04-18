using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.Models
{
    public class Loja
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CpfDono { get; set; }
        public string RgDono { get; set; }
        public string OrgaoEmissor { get; set; }
    }
}