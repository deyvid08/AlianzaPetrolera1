namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Matricula1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Matriculas", name: "Insc_Id_Insc_ID", newName: "Insc_Id");
            RenameIndex(table: "dbo.Matriculas", name: "IX_Insc_Id_Insc_ID", newName: "IX_Insc_Id");
            AddColumn("dbo.Matriculas", "Mat_IdEst", c => c.String());
            AddColumn("dbo.Matriculas", "Mat_Nom", c => c.String());
            AddColumn("dbo.Matriculas", "Mat_Apel", c => c.String());
            AddColumn("dbo.Matriculas", "Mat_Doc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Matriculas", "Mat_Doc");
            DropColumn("dbo.Matriculas", "Mat_Apel");
            DropColumn("dbo.Matriculas", "Mat_Nom");
            DropColumn("dbo.Matriculas", "Mat_IdEst");
            RenameIndex(table: "dbo.Matriculas", name: "IX_Insc_Id", newName: "IX_Insc_Id_Insc_ID");
            RenameColumn(table: "dbo.Matriculas", name: "Insc_Id", newName: "Insc_Id_Insc_ID");
        }
    }
}
