namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEnhancementProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "TotalQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Vat", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Discount", c => c.Int(nullable: false));
            DropColumn("dbo.ProductStocks", "StockTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductStocks", "StockTypeId", c => c.Guid(nullable: false));
            DropColumn("dbo.Products", "Discount");
            DropColumn("dbo.Products", "Vat");
            DropColumn("dbo.Products", "TotalQuantity");
        }
    }
}
