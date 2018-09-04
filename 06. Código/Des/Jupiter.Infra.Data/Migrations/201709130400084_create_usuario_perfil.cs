namespace Jupiter.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_usuario_perfil : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Perfil",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Tipo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Email = c.String(),
                        Senha = c.String(nullable: false, maxLength: 200),
                        DataDeCadastro = c.DateTime(nullable: false),
                        IdPerfil = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Perfil", t => t.IdPerfil, cascadeDelete: true)
                .Index(t => t.IdPerfil);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "IdPerfil", "dbo.Perfil");
            DropIndex("dbo.Usuario", new[] { "IdPerfil" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Perfil");
        }
    }
}
