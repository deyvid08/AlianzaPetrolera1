namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nuevamigracion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matriculas",
                c => new
                    {
                        Matri_Id = c.Int(nullable: false, identity: true),
                        Peri_Id = c.Int(nullable: false),
                        Cate_Id = c.String(),
                        Matr_Fecha = c.DateTime(nullable: false),
                        Matri_Esta = c.Int(nullable: false),
                        Insc_Id_Insc_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Matri_Id)
                .ForeignKey("dbo.Inscripcions", t => t.Insc_Id_Insc_ID, cascadeDelete: true)
                .Index(t => t.Insc_Id_Insc_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matriculas", "Insc_Id_Insc_ID", "dbo.Inscripcions");
            DropIndex("dbo.Matriculas", new[] { "Insc_Id_Insc_ID" });
            DropTable("dbo.Matriculas");
        }
    }
}
