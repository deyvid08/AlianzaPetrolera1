namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tres : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReciboCajas", "Reci_Mpago", c => c.String());
            AlterColumn("dbo.ReciboCajas", "Banco_Id", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReciboCajas", "Banco_Id", c => c.String(nullable: false));
            AlterColumn("dbo.ReciboCajas", "Reci_Mpago", c => c.String(nullable: false));
        }
    }
}
