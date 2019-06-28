namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reciboconce : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ReciboCajas", "Reci_Num", c => c.Int(nullable: false));
            AddColumn("dbo.ReciboCajas", "Reci_NomUs", c => c.String());
            AddColumn("dbo.ReciboCajas", "Reci_ApeUs", c => c.String());
            AddColumn("dbo.ReciboCajas", "Reci_DocUs", c => c.String());
            AddColumn("dbo.ReciboCajas", "Reci_CateUs", c => c.String());
            AddColumn("dbo.ReciboCajas", "Desc_Matri", c => c.Single());
            AddColumn("dbo.ReciboCajas", "Desc_Poli", c => c.Single());
            AddColumn("dbo.ReciboCajas", "Desc_Unif", c => c.Single());
            AddColumn("dbo.ReciboCajas", "Desc_Mensu", c => c.Single());
            AlterColumn("dbo.ReciboCajas", "Costo_Matri", c => c.Single());
            AlterColumn("dbo.ReciboCajas", "Costo_Poli", c => c.Single());
            AlterColumn("dbo.ReciboCajas", "Costo_Unif", c => c.Single());
            AlterColumn("dbo.ReciboCajas", "Costo_Mensu", c => c.Single());
            DropColumn("dbo.ReciboCajas", "Matri_Esta");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ReciboCajas", "Matri_Esta", c => c.Int(nullable: false));
            AlterColumn("dbo.ReciboCajas", "Costo_Mensu", c => c.Int(nullable: false));
            AlterColumn("dbo.ReciboCajas", "Costo_Unif", c => c.Int(nullable: false));
            AlterColumn("dbo.ReciboCajas", "Costo_Poli", c => c.Int(nullable: false));
            AlterColumn("dbo.ReciboCajas", "Costo_Matri", c => c.Int(nullable: false));
            DropColumn("dbo.ReciboCajas", "Desc_Mensu");
            DropColumn("dbo.ReciboCajas", "Desc_Unif");
            DropColumn("dbo.ReciboCajas", "Desc_Poli");
            DropColumn("dbo.ReciboCajas", "Desc_Matri");
            DropColumn("dbo.ReciboCajas", "Reci_CateUs");
            DropColumn("dbo.ReciboCajas", "Reci_DocUs");
            DropColumn("dbo.ReciboCajas", "Reci_ApeUs");
            DropColumn("dbo.ReciboCajas", "Reci_NomUs");
            DropColumn("dbo.ReciboCajas", "Reci_Num");
        }
    }
}
