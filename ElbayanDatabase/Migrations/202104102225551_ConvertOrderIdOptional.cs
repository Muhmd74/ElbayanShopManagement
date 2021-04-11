namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConvertOrderIdOptional : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductStocks", "OrderId", "dbo.Orders");
            DropIndex("dbo.ProductStocks", new[] { "OrderId" });
            AlterColumn("dbo.ProductStocks", "OrderId", c => c.Guid());
            CreateIndex("dbo.ProductStocks", "OrderId");
            AddForeignKey("dbo.ProductStocks", "OrderId", "dbo.Orders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductStocks", "OrderId", "dbo.Orders");
            DropIndex("dbo.ProductStocks", new[] { "OrderId" });
            AlterColumn("dbo.ProductStocks", "OrderId", c => c.Guid(nullable: false));
            CreateIndex("dbo.ProductStocks", "OrderId");
            AddForeignKey("dbo.ProductStocks", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
        }
    }
}
