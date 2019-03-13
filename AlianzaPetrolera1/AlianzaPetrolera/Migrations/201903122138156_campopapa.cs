namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class campopapa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personas", "Padre_Id", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personas", "Padre_Id");
        }
    }
}
