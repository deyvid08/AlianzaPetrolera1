namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatosHijo : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Personas", "Pers_NickNom");
            DropColumn("dbo.Personas", "Pers_Pwd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personas", "Pers_Pwd", c => c.String());
            AddColumn("dbo.Personas", "Pers_NickNom", c => c.String());
        }
    }
}
