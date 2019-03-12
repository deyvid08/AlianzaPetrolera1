namespace AlianzaPetrolera.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigrationPersona : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Cate_Id = c.Int(nullable: false, identity: true),
                        Cate_Name = c.String(),
                    })
                .PrimaryKey(t => t.Cate_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Categorias");
        }
    }
}
