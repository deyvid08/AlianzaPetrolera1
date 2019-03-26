namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class restauracionBD : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Matriculas", "Matri_Id", "dbo.Inscripcions");
            DropIndex("dbo.Matriculas", new[] { "Matri_Id" });
            DropPrimaryKey("dbo.Matriculas");
            AddColumn("dbo.Matriculas", "Insc_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Matriculas", "Matri_Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Matriculas", "Cate_Id", c => c.String());
            AddPrimaryKey("dbo.Matriculas", "Matri_Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Matriculas");
            AlterColumn("dbo.Matriculas", "Cate_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Matriculas", "Matri_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Matriculas", "Insc_Id");
            AddPrimaryKey("dbo.Matriculas", "Matri_Id");
            CreateIndex("dbo.Matriculas", "Matri_Id");
            AddForeignKey("dbo.Matriculas", "Matri_Id", "dbo.Inscripcions", "Insc_ID");
        }
    }
}
