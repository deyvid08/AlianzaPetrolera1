namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inscripcion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inscripcions",
                c => new
                    {
                        Insc_ID = c.Int(nullable: false, identity: true),
                        Pers_Doc = c.String(),
                        Insc_Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Insc_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Inscripcions");
        }
    }
}
