using System.Data.Entity.ModelConfiguration.Conventions;
using Jupiter.Domain.Entities;
using System.Data.Entity;
using Jupiter.Infra.Data.DbMapping;

namespace Jupiter.Infra.Data.Context
{
    public class JupiterContext : DbContext
    {
        public JupiterContext()
            : base("JupiterConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Perfil> Perfil { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new UsuarioDbMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
