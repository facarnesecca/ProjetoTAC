using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fabio.ProjetoTAC.Models
{
    public class Pessoa
    {
        [Key]
        public int id { get; set; }

        
        [Display (Name = "Nome")]
        [Required(ErrorMessage="Informe o nome da pessoa")]
        public string Nome{ get; set; }

        [Display(Name = "CPF/CPNJ")]
        [RegularExpression(@"^\d{3}.d{3}.d{3}-d{2}$ |^\d{2}.\d{3}.\d{3}/.\d{4}-\d{2}$", ErrorMessage = "O Valor informado não está correto")]
        public string CPF { get; set; }

        [Display(Name = "Data Nascimento")]
        [Required(ErrorMessage = "Informe a data de nascimetno da pessoa")]
        public DateTime Nascimento { get; set; }

        [Display (Name="Telefone")]
        [Required (ErrorMessage="O Telefone é obrigatório")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Forneça o número do telefone no formato (000) 000-0000")]
        public string Telefone { get; set; }

        [Display (Name="E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Display(Name = "Tipo Documento")]
        public string tipodoc { get; set; }

        [Display(Name = "Documento")]
        public string documento { get; set; }

        [Display(Name = "Oustras Informações")]
        [StringLength(5000)]
        [DataType(DataType.MultilineText)]
        public string Detalhes { get; set; }

        public int idendereco { get; set; }
        [ForeignKey ("idendereco"), InverseProperty("Endereco")]
        public virtual Endereco Endereco { get; set; }



        
        

    }
}