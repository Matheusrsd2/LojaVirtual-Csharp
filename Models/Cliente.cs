using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtualCsharp.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MinLength(5, ErrorMessage = "O nome deve conter ao menos 4 caracteres")]
        [MaxLength (80, ErrorMessage = "O nome deve conter no máximo 15 caracteres")]
        public string Nome { get; set; }
        public string Email { get; set ; }
        public string Senha { get; set; }
        public string Cpf { get; set ; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
