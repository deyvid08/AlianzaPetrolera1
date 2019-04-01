namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Matricula : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Matriculas", "Insc_Id_Insc_ID", "dbo.Inscripcions");
            DropIndex("dbo.Matriculas", new[] { "Insc_Id_Insc_ID" });
            RenameColumn(table: "dbo.Matriculas", name: "Insc_Id_Insc_ID", newName: "Inscripcion_Insc_ID");
            AddColumn("dbo.Matriculas", "Insc_Id", c => c.String());
            AddColumn("dbo.Matriculas", "Matri_IdEstu", c => c.String());
            AddColumn("dbo.Matriculas", "Matri_Nom", c => c.String());
            AddColumn("dbo.Matriculas", "Matri_Apel", c => c.String());
            AddColumn("dbo.Matriculas", "Matri_Doc", c => c.String());
            AlterColumn("dbo.Matriculas", "Cate_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Matriculas", "Inscripcion_Insc_ID", c => c.Int());
            CreateIndex("dbo.Matriculas", "Inscripcion_Insc_ID");
            AddForeignKey("dbo.Matriculas", "Inscripcion_Insc_ID", "dbo.Inscripcions", "Insc_ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matriculas", "Inscripcion_Insc_ID", "dbo.Inscripcions");
            DropIndex("dbo.Matriculas", new[] { "Inscripcion_Insc_ID" });
            AlterColumn("dbo.Matriculas", "Inscripcion_Insc_ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Matriculas", "Cate_Id", c => c.String());
            DropColumn("dbo.Matriculas", "Matri_Doc");
            DropColumn("dbo.Matriculas", "Matri_Apel");
            DropColumn("dbo.Matriculas", "Matri_Nom");
            DropColumn("dbo.Matriculas", "Matri_IdEstu");
            DropColumn("dbo.Matriculas", "Insc_Id");
            RenameColumn(table: "dbo.Matriculas", name: "Inscripcion_Insc_ID", newName: "Insc_Id_Insc_ID");
            CreateIndex("dbo.Matriculas", "Insc_Id_Insc_ID");
            AddForeignKey("dbo.Matriculas", "Insc_Id_Insc_ID", "dbo.Inscripcions", "Insc_ID", cascadeDelete: true);
        }
    }
}
