using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoPraticaOficial.Models
{
    public class Cliente
    {

        public Cliente()
        {

        }

       // [Required]
        public int Id { get; set; }

        //[Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        //[StringLength(100, MinimumLength = 4)]
        //[Required(ErrorMessage = "Informe o seu email")]// arrumar no css
        //[RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O CPF do usuário é obrigatório", AllowEmptyStrings = false)]// arrumar no css
        [Display(Name = "Cpf do cliente")]
        //ele digitar só número
        public string Cpf { get; set; }

        //[Required(ErrorMessage = "A senha é obrigatória", AllowEmptyStrings = false)] // arrumar no css
       // [Display(Name = "Informe a Senha")]
        //[StringLength(10, MinimumLength = 4)]
        public string Senha { get; set; }

        //[Required(ErrorMessage = "O telefone do usuário é obrigatório", AllowEmptyStrings = false)]// arrumar no css
        //[Display(Name ="Telefone do cliente")]
        //[DisplayFormat(DataFormatString = )]
        //digitar só número por causa da função do css
        public string Telefone { get; set; }
    }
}