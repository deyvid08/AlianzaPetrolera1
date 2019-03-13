namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recibocaja : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ReciboCajas",
                c => new
                    {
                        Reci_Id = c.Int(nullable: false, identity: true),
                        Costo_Matri = c.Int(nullable: false),
                        Costo_Poli = c.Int(nullable: false),
                        Costo_Unif = c.Int(nullable: false),
                        Costo_Mensu = c.Int(nullable: false),
                        Matr_Fecha = c.DateTime(nullable: false),
                        Matri_Esta = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Reci_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReciboCajas");
        }
    }
}
