namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderIdToProductStocks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductStocks", "OrderId", c => c.Guid(nullable: false));
            CreateIndex("dbo.ProductStocks", "OrderId");
            AddForeignKey("dbo.ProductStocks", "OrderId", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductStocks", "OrderId", "dbo.Orders");
            DropIndex("dbo.ProductStocks", new[] { "OrderId" });
            DropColumn("dbo.ProductStocks", "OrderId");
        }
    }
}
