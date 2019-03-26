namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkinscri3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matriculas", "Insc_Id_Insc_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Matriculas", "Insc_Id_Insc_ID");
            AddForeignKey("dbo.Matriculas", "Insc_Id_Insc_ID", "dbo.Inscripcions", "Insc_ID", cascadeDelete: true);
            DropColumn("dbo.Matriculas", "Insc_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matriculas", "Insc_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.Matriculas", "Insc_Id_Insc_ID", "dbo.Inscripcions");
            DropIndex("dbo.Matriculas", new[] { "Insc_Id_Insc_ID" });
            DropColumn("dbo.Matriculas", "Insc_Id_Insc_ID");
        }
    }
}
