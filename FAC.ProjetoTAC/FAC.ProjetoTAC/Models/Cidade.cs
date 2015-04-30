using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FAC.ProjetoTAC.Models;

namespace Fabio.ProjetoTAC.Models
{
    public class Cidade
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Informe a Cidade")]
        public string nome { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Informe o Estado ")]
        [UIHint("Create")]     
        public int idUF { get; set; }

      }
}
