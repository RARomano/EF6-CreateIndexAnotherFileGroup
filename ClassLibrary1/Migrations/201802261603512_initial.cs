namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ClusteredName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name)
                .Index(t => t.ClusteredName, clustered: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Models", new[] { "ClusteredName" });
            DropIndex("dbo.Models", new[] { "Name" });
            DropTable("dbo.Models");
        }
    }
}
