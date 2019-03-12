namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class registrohijo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personas", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Personas", "Pers_TypeDoc", c => c.Int(nullable: false));
            AlterColumn("dbo.Personas", "Rolp_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Personas", "UserId");
            AddForeignKey("dbo.Personas", "UserId", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Personas", "Pers_Mail2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personas", "Pers_Mail2", c => c.String());
            DropForeignKey("dbo.Personas", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Personas", new[] { "UserId" });
            AlterColumn("dbo.Personas", "Rolp_Id", c => c.Int());
            AlterColumn("dbo.Personas", "Pers_TypeDoc", c => c.String());
            DropColumn("dbo.Personas", "UserId");
        }
    }
}
