using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fabio.ProjetoTAC.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        
        [Display(Name= "Login do Usuário")]
        [Required]
        public string login { get; set; }

        [Display(Name = "Nome do usuário")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Senha do usuário")]
        [Required]
        [DataType(DataType.Password)]
        public string senha { get; set; }

    }
}