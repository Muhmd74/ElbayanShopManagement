namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnhancemntProductStock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductStocks", "StockStatues", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductStocks", "StockStatues");
        }
    }
}
