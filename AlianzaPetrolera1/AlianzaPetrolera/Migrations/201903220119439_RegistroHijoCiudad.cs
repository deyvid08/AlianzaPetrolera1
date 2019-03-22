namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RegistroHijoCiudad : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personas", "Ubic_Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personas", "Ubic_Id", c => c.Int());
        }
    }
}
