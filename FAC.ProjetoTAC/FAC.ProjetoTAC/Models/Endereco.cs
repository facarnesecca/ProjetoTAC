using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fabio.ProjetoTAC.Models
{
    public class Endereco
    {
        [Key]
        public int idendereco { get; set; }

        
        [Display (Name = "CEP")]
        [Required(ErrorMessage="Informe o CEP")]
        [RegularExpression(@"^\d{8}$|^\d{5}-\d{3}$", ErrorMessage = "O código postal deverá estar no formato 00000000 ou 00000-000")]
        public string CEP { get; set; }

        [Display (Name = "Logradouro")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "O Logradouro deve term pelo menos 5 cacter")]
        public string logra { get; set; }


        [Display(Name = "Cidade")]
        [UIHint("Create")]
        public int idcidade{ get; set; }

        

    }
}