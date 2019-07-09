namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ReciboCajas", "Banco_Id", "dbo.Bancoes");
            DropIndex("dbo.ReciboCajas", new[] { "Banco_Id" });
            AlterColumn("dbo.ReciboCajas", "Banco_Id", c => c.Int());
            CreateIndex("dbo.ReciboCajas", "Banco_Id");
            AddForeignKey("dbo.ReciboCajas", "Banco_Id", "dbo.Bancoes", "Banc_Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReciboCajas", "Banco_Id", "dbo.Bancoes");
            DropIndex("dbo.ReciboCajas", new[] { "Banco_Id" });
            AlterColumn("dbo.ReciboCajas", "Banco_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.ReciboCajas", "Banco_Id");
            AddForeignKey("dbo.ReciboCajas", "Banco_Id", "dbo.Bancoes", "Banc_Id", cascadeDelete: true);
        }
    }
}
