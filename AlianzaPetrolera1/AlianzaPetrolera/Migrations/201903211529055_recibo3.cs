namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recibo3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReciboCajas", "Matri_CosTota", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReciboCajas", "Matri_CosTota", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
