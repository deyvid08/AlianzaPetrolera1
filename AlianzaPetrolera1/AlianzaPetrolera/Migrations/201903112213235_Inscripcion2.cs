namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inscripcion2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Inscripcions", "Insc_Fecha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Inscripcions", "Insc_Fecha", c => c.DateTime(nullable: false));
        }
    }
}
