using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.Models
{
    public class Loja
    {
        public Loja()
        {

        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "E-mail obrigatório")]// arrumar no css
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }
        [Required(ErrorMessage = "CPF obrigatório")]
        public string CpfDono { get; set; }
        [Required(ErrorMessage = "RG obrigatório")]
        public string RgDono { get; set; }
        [Required(ErrorMessage = "Orgão Emissor obrigatório")]
        //criar uma view para um listBox
        public string OrgaoEmissor { get; set; }
    }
}