using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FAC.ProjetoTAC.Models
{
    public class Estado
    {
        [Key]
        public int iduf { get; set; }
        
        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Informe o Estado")]
        public string uf { get; set; }

    }
}