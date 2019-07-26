namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReciboCajas", "Reci_Mpago", c => c.String(nullable: false));
            AlterColumn("dbo.ReciboCajas", "Banco_Id", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReciboCajas", "Banco_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ReciboCajas", "Reci_Mpago", c => c.Int(nullable: false));
        }
    }
}
