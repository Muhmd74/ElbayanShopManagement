namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTimeToProductPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductPrices", "ProcessType", c => c.String());
            AddColumn("dbo.ProductStocks", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.ProductStocks", "StockStatues");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductStocks", "StockStatues", c => c.String());
            DropColumn("dbo.ProductStocks", "DateTime");
            DropColumn("dbo.ProductPrices", "ProcessType");
        }
    }
}
