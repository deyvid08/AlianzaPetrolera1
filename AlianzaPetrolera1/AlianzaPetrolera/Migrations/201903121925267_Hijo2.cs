namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hijo2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Personas", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Persona_Pers_Cod", "dbo.Personas");
            DropIndex("dbo.Personas", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "Persona_Pers_Cod" });
            CreateTable(
                "dbo.Hijoes",
                c => new
                    {
                        Hijo_Cod = c.String(nullable: false, maxLength: 128),
                        Hijo_NickNom = c.String(),
                        Hijo_Pwd = c.String(),
                        Hijo_Nom = c.String(),
                        Hijo_Lstn1 = c.String(),
                        Hijo_Lstn2 = c.String(),
                        Hijo_TypeDoc = c.Int(nullable: false),
                        Hijo_Doc = c.String(),
                        Hijo_Birth = c.DateTime(),
                        Hijo_Dir = c.String(),
                        Hijo_Tel1 = c.String(),
                        Hijo_Tel2 = c.String(),
                        Hijo_Mail1 = c.String(),
                        UserId = c.String(maxLength: 128),
                        Hijo_Ingreso = c.DateTime(),
                        Hijo_TotalPoints = c.Int(nullable: false),
                        Ubic_Id = c.Int(),
                        Rolp_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Hijo_Cod)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
            AddColumn("dbo.AspNetUsers", "Hijo_Hijo_Cod", c => c.String(maxLength: 128));
            CreateIndex("dbo.AspNetUsers", "Hijo_Hijo_Cod");
            AddForeignKey("dbo.AspNetUsers", "Hijo_Hijo_Cod", "dbo.Hijoes", "Hijo_Cod");
            DropColumn("dbo.AspNetUsers", "Persona_Pers_Cod");
            DropTable("dbo.Personas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        Pers_Cod = c.String(nullable: false, maxLength: 128),
                        Pers_NickNom = c.String(),
                        Pers_Pwd = c.String(),
                        Pers_Nom = c.String(),
                        Pers_Lstn1 = c.String(),
                        Pers_Lstn2 = c.String(),
                        Pers_TypeDoc = c.Int(nullable: false),
                        Pers_Doc = c.String(),
                        Pers_Birth = c.DateTime(),
                        Pers_Dir = c.String(),
                        Pers_Tel1 = c.String(),
                        Pers_Tel2 = c.String(),
                        Pers_Mail1 = c.String(),
                        UserId = c.String(maxLength: 128),
                        Pers_Ingreso = c.DateTime(),
                        Pers_TotalPoints = c.Int(nullable: false),
                        Ubic_Id = c.Int(),
                        Rolp_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pers_Cod);
            
            AddColumn("dbo.AspNetUsers", "Persona_Pers_Cod", c => c.String(maxLength: 128));
            DropForeignKey("dbo.AspNetUsers", "Hijo_Hijo_Cod", "dbo.Hijoes");
            DropForeignKey("dbo.Hijoes", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUsers", new[] { "Hijo_Hijo_Cod" });
            DropIndex("dbo.Hijoes", new[] { "UserId" });
            DropColumn("dbo.AspNetUsers", "Hijo_Hijo_Cod");
            DropTable("dbo.Hijoes");
            CreateIndex("dbo.AspNetUsers", "Persona_Pers_Cod");
            CreateIndex("dbo.Personas", "UserId");
            AddForeignKey("dbo.AspNetUsers", "Persona_Pers_Cod", "dbo.Personas", "Pers_Cod");
            AddForeignKey("dbo.Personas", "UserId", "dbo.AspNetUsers", "Id");
        }
    }
}
