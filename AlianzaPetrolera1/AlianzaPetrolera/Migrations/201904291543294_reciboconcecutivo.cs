namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reciboconcecutivo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReciboCajas", "Reci_Num", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReciboCajas", "Reci_Num", c => c.String());
        }
    }
}
