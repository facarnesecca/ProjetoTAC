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
    
    public partial class Estado
    {
        public Estado()
        {
            this.Cidade1 = new HashSet<Cidade>();
        }
    
        public int Iduf { get; set; }
        public string UF { get; set; }
        public string Descricao { get; set; }
    
        public virtual ICollection<Cidade> Cidade1 { get; set; }
    }
}
