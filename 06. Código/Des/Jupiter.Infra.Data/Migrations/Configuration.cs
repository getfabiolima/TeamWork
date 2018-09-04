namespace Jupiter.Infra.Data.Migrations
{
    using Jupiter.Domain.Entities;
    using Jupiter.Domain.Entities.Enum;
    using Jupiter.Infra.Data.Context;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<JupiterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JupiterContext context)
        {
            context.Perfil.Add(new Perfil(Guid.Parse("3ceff678-ba3d-44da-9bc8-4f07d93ad603"), TipoPerfil.Gerente));
            context.Perfil.Add(new Perfil(Guid.Parse("64f5a981-ff74-4d2c-ab21-0995e1f8d3a1"), TipoPerfil.UsuarioCadastrado));

            context.Usuario.Add(new Usuario() { Nome = "jupiter", UserName = "Jupiter", Senha = "jup1t34", Email = "jupiter@jupiter.com.br", IdPerfil = Guid.Parse("64f5a981-ff74-4d2c-ab21-0995e1f8d3a1") });

            context.SaveChanges();
        }
    }
}
