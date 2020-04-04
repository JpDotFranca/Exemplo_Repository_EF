namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoCachorro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cachorroes",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Cor = c.String(),
                        Porte = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Identificador);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cachorroes");
        }
    }
}
