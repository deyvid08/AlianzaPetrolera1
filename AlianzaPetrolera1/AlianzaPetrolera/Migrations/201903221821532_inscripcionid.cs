namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inscripcionid : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Inscripcions");
            AlterColumn("dbo.Inscripcions", "Insc_ID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Inscripcions", "Insc_ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Inscripcions");
            AlterColumn("dbo.Inscripcions", "Insc_ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Inscripcions", "Insc_ID");
        }
    }
}
