namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropertyViewsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PropertyViews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        BuyerId = c.String(),
                        PropertyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Properties", t => t.PropertyId, cascadeDelete: true)
                .Index(t => t.PropertyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PropertyViews", "PropertyId", "dbo.Properties");
            DropIndex("dbo.PropertyViews", new[] { "PropertyId" });
            DropTable("dbo.PropertyViews");
        }
    }
}
