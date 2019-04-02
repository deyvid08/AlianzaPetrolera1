namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReciboCajaCamposalmacenados : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReciboCajas", "Costo_Matri", c => c.Single());
            AlterColumn("dbo.ReciboCajas", "Costo_Poli", c => c.Single());
            AlterColumn("dbo.ReciboCajas", "Costo_Unif", c => c.Single());
            AlterColumn("dbo.ReciboCajas", "Costo_Mensu", c => c.Single());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReciboCajas", "Costo_Mensu", c => c.Int(nullable: false));
            AlterColumn("dbo.ReciboCajas", "Costo_Unif", c => c.Int(nullable: false));
            AlterColumn("dbo.ReciboCajas", "Costo_Poli", c => c.Int(nullable: false));
            AlterColumn("dbo.ReciboCajas", "Costo_Matri", c => c.Int(nullable: false));
        }
    }
}
