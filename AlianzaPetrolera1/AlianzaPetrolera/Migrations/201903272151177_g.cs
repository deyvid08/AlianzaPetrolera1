namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class g : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Matriculas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Matriculas",
                c => new
                    {
                        Matri_Id = c.Int(nullable: false, identity: true),
                        Insc_Id = c.Int(nullable: false),
                        Peri_Id = c.Int(nullable: false),
                        Cate_Id = c.String(),
                        Matr_Fecha = c.DateTime(nullable: false),
                        Matri_Esta = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Matri_Id);
            
        }
    }
}
