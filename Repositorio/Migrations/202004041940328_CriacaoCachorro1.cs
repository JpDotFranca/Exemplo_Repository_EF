namespace Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoCachorro1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cachorroes", "SobreNome", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cachorroes", "SobreNome");
        }
    }
}
