using Jupiter.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Jupiter.Infra.Data.DbMapping
{
    public class UsuarioDbMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioDbMapping()
        {            
            Property(x => x.UserName).HasMaxLength(50).IsRequired();
            Property(x => x.Senha).HasMaxLength(200).IsRequired();

            HasRequired(x => x.Perfil)
                .WithMany()
                .HasForeignKey(x => x.IdPerfil);
        }
    }
}
