//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FAC.ProjetoTACFinal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Endereco
    {
        public int IdEndereco { get; set; }
        public string Nome { get; set; }
        public string CEP { get; set; }
        public Nullable<int> idCidade { get; set; }
    }
}
