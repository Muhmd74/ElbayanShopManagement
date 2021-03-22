namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteOrderIdFromProductSTock : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductStocks", "OrderId", "dbo.Orders");
            AddForeignKey("dbo.ProductStocks", "OrderId", "dbo.Orders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductStocks", "OrderId", "dbo.Orders");
            AddForeignKey("dbo.ProductStocks", "OrderId", "dbo.Orders", "Id");
        }
    }
}
