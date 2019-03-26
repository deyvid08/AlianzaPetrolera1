namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class errorinscripcion : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Matriculas", "Insc_Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Matriculas", "Insc_Id", c => c.String());
        }
    }
}
