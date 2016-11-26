namespace OrangeBricks.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBuyerRelationshipToOffers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "BuyerId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Offers", "BuyerId");
        }
    }
}
