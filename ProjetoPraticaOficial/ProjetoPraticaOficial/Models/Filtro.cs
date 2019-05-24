using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.Models
{
    public class Filtro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Aniaml obrigatório", AllowEmptyStrings = false)]
        public string Animal { get; set; }
 
    }
}