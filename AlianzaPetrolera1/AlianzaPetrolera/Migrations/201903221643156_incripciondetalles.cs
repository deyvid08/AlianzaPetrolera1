namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class incripciondetalles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inscripcions", "Insc_ApeEst", c => c.String());
            AddColumn("dbo.Inscripcions", "Insc_DocEst", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Inscripcions", "Insc_DocEst");
            DropColumn("dbo.Inscripcions", "Insc_ApeEst");
        }
    }
}
