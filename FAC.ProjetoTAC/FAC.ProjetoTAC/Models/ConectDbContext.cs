using System.Data.Entity;
using Fabio.ProjetoTAC.Models;

namespace FAC.ProjetoTAC.Models
{
    public class ConectDbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<FAC.ProjetoTAC.Models.ConectDbContext>());

        public ConectDbContext() : base("name=ConectDbContext")
        {
        }

        public DbSet<Estado> Estadoes { get; set; }

        public DbSet<Cidade> Cidades{ get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Contato> Contatos { get; set; }
    }
}
