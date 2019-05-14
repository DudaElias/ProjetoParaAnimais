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
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome obrigatório", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-z]|[A-Z]+$", ErrorMessage = "Use apenas caracteres alfabéticos.")]
        //está dando erro quando coloca <><
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "E-mail obrigatório")]// arrumar no css
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Required(ErrorMessage = "CPF obrigatório", AllowEmptyStrings = false)]// arrumar no css
        [Display(Name = "Cpf do cliente")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Senha obrigatória", AllowEmptyStrings = false)] // arrumar no css
        [StringLength(50, ErrorMessage = "A senha deve ter pelo menos 6 caracteres. Tente inserir outra senha.",MinimumLength = 6)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Telefone obrigatório", AllowEmptyStrings = false)]// arrumar no css
        [StringLength(12, ErrorMessage = "Número inválido", MinimumLength = 10)]
        public string Telefone { get; set; }
    }
}