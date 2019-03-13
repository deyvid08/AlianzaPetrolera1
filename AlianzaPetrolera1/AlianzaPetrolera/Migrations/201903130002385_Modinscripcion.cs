namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modinscripcion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Inscripcions", "Insc_NomEst", c => c.String());
            AddColumn("dbo.Inscripcions", "Insc_FechInsc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Personas", "Pers_TypeDoc", c => c.Int(nullable: false));
            AlterColumn("dbo.Personas", "Rolp_Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personas", "Rolp_Id", c => c.Int());
            AlterColumn("dbo.Personas", "Pers_TypeDoc", c => c.String());
            DropColumn("dbo.Inscripcions", "Insc_FechInsc");
            DropColumn("dbo.Inscripcions", "Insc_NomEst");
        }
    }
}
