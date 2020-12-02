using System;
using System.ComponentModel.DataAnnotations;

namespace LojaVirtualCsharp.Models
{
    public class Contato
    {
        [Required]
        [MinLength(5)]
        public String Nome {get; set; }
        [Required]
        [EmailAddress]
        public String Email { get; set; }
        [Required]
        public String Texto {get; set; }
        
    }
}