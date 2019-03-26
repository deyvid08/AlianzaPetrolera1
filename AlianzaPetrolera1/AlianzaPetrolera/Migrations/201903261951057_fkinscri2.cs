namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkinscri2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Matriculas", "Matri_Id", "dbo.Inscripcions");
            DropIndex("dbo.Matriculas", new[] { "Matri_Id" });
            DropPrimaryKey("dbo.Matriculas");
            AddColumn("dbo.Matriculas", "Insc_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Matriculas", "Matri_Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Matriculas", "Matri_Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Matriculas");
            AlterColumn("dbo.Matriculas", "Matri_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Matriculas", "Insc_Id");
            AddPrimaryKey("dbo.Matriculas", "Matri_Id");
            CreateIndex("dbo.Matriculas", "Matri_Id");
            AddForeignKey("dbo.Matriculas", "Matri_Id", "dbo.Inscripcions", "Insc_ID");
        }
    }
}
