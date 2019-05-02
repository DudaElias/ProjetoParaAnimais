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

        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        []
        public string Email { get; set; }
        []
        public string Cpf { get; set; }
        []
        public string Senha { get; set; }
        []
        public string Telefone { get; set; }
    }
}