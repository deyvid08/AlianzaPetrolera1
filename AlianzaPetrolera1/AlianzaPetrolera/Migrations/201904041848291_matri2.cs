namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class matri2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matriculas", "Mat_IdEst", c => c.String());
            AddColumn("dbo.Matriculas", "Mat_Nom", c => c.String());
            AddColumn("dbo.Matriculas", "Mat_Apel", c => c.String());
            AddColumn("dbo.Matriculas", "Mat_Doc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Matriculas", "Mat_Doc");
            DropColumn("dbo.Matriculas", "Mat_Apel");
            DropColumn("dbo.Matriculas", "Mat_Nom");
            DropColumn("dbo.Matriculas", "Mat_IdEst");
        }
    }
}
