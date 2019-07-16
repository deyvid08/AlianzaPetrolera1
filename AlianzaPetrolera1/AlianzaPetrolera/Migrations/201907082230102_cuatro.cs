namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cuatro : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReciboCajas", "Reci_Mpago", c => c.Int(nullable: false));
            AddColumn("dbo.ReciboCajas", "Reci_Obse", c => c.String());
            DropColumn("dbo.ReciboCajas", "Matr_Pago");
            DropColumn("dbo.ReciboCajas", "Matr_Obse");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ReciboCajas", "Matr_Obse", c => c.String());
            AddColumn("dbo.ReciboCajas", "Matr_Pago", c => c.Int(nullable: false));
            DropColumn("dbo.ReciboCajas", "Reci_Obse");
            DropColumn("dbo.ReciboCajas", "Reci_Mpago");
        }
    }
}
