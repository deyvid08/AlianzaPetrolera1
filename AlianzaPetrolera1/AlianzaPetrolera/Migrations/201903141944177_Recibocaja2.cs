namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Recibocaja2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReciboCajas", "Matri_CosTota", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReciboCajas", "Matri_CosTota");
        }
    }
}
