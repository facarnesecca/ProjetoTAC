using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
        [EnumDataType(typeof(EstadosUF))]
        public string UF { get; set; }

        [Display(Name = "Estado2")]
        [EnumDataType(typeof(EstadosUF))]
        public EstadosUF UF2 { get; set; }



        public enum EstadosUF
        {
            AC, // Acre
            AL, // Alagoas
            AP, // Amapá
            AM, // Amazonas
            BA, // Bahia
            CE, // Ceará
            DF, // Distrito Federal
            ES, // Espírito Santo
            GO, // Goiás
            MA, // Maranhão
            MT, // Mato Grosso
            MS, // Mato Grosso do Sul
            MG, // Minas Gerais
            PA, // Pará
            PB, // Paraíba
            PR, // Paraná
            PE, // Pernambuco
            PI, // Piauí
            RR, // Roraima
            RO, // Rondônia
            RJ, // Rio de Janeiro
            RN, // Rio Grande do Norte
            RS, // Rio Grande do Sul
            SC, // Santa Catarina
            SP, // São Paulo
            SE, // Sergipe
            TO // Tocantins

        }

    }
}
