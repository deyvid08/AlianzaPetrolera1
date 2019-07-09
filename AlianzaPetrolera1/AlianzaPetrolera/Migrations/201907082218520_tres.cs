namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tres : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReciboCajas", "Matr_Pago", c => c.Int(nullable: false));
            AddColumn("dbo.ReciboCajas", "Matr_Obse", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ReciboCajas", "Matr_Obse");
            DropColumn("dbo.ReciboCajas", "Matr_Pago");
        }
    }
}
