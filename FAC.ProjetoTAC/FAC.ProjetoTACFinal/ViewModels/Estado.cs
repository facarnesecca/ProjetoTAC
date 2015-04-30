using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FAC.ProjetoTACFinal.Models;

namespace FAC.ProjetoTACFinal.ViewModels
{
    public class Estado
    {
        private ModelProjetoContainer db = new ModelProjetoContainer();

        public List<Estado> EstadosListar() {

            return db.Estados.ToList () ;

        }
    }
}