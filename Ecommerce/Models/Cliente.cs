﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtualCsharp.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set ; }
        public string Senha { get; set; }
        public string Cpf { get; set ; }
        public string Sexo { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
