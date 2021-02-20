namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnhancementRelationInLargeUnitSmall : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageUrl", c => c.String());
            AddColumn("dbo.Products", "PurchaseDefaultPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "SaleDefaultPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "WholesalePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Products", "IsUnitSale", c => c.Boolean(nullable: false));
            AddColumn("dbo.SmallUnits", "LargeUnitId", c => c.Guid(nullable: false));
            CreateIndex("dbo.SmallUnits", "LargeUnitId");
            AddForeignKey("dbo.SmallUnits", "LargeUnitId", "dbo.LargeUnits", "Id");
            DropColumn("dbo.Products", "DefaultPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "DefaultPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.SmallUnits", "LargeUnitId", "dbo.LargeUnits");
            DropIndex("dbo.SmallUnits", new[] { "LargeUnitId" });
            DropColumn("dbo.SmallUnits", "LargeUnitId");
            DropColumn("dbo.Products", "IsUnitSale");
            DropColumn("dbo.Products", "WholesalePrice");
            DropColumn("dbo.Products", "SaleDefaultPrice");
            DropColumn("dbo.Products", "PurchaseDefaultPrice");
            DropColumn("dbo.Products", "ImageUrl");
        }
    }
}
