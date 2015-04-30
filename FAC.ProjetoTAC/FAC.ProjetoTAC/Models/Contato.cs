using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FAC.ProjetoTAC.Models
{
    public class Contato
    {
        [Key]
        public int idcontato { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome da pessoa")]
        public string Nome { get; set; }

        [Display(Name = "CPF/CPNJ")]
        [RegularExpression(@"^\d{3}.d{3}.d{3}-d{2}$ |^\d{2}.\d{3}.\d{3}/.\d{4}-\d{2}$", ErrorMessage = "O Valor informado não está correto")]
        public string CPF { get; set; }

        [Display(Name = "Data Nascimento")]
        [Required(ErrorMessage = "Informe a data de nascimetno da pessoa")]
        public DateTime Nascimento { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O Telefone é obrigatório")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Forneça o número do telefone no formato (000) 000-0000")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Documento")]
        public string documento { get; set; }

        [Display(Name = "Oustras Informações")]
        [StringLength(5000)]
        [DataType(DataType.MultilineText)]
        public string Detalhes { get; set; }

        [Display(Name = "Endereço")]
        [UIHint("EnderecoDropDownList")]
        public int idendereco { get; set; }

        [Display(Name = "Numero")]
        public string numero { get; set; }

        [Display(Name = "Complemento")]
        public string complemento { get; set; }


    }
}