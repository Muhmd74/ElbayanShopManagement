namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductMode : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductStocks", "StockTypeId", "dbo.StockTypes");
            DropIndex("dbo.ProductStocks", new[] { "StockTypeId" });
            AddColumn("dbo.ProductStocks", "StockStatues", c => c.String());
            DropTable("dbo.StockTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StockTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Sale = c.String(),
                        Procurement = c.String(),
                        Returns = c.String(),
                        Damaged = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.ProductStocks", "StockStatues");
            CreateIndex("dbo.ProductStocks", "StockTypeId");
            AddForeignKey("dbo.ProductStocks", "StockTypeId", "dbo.StockTypes", "Id", cascadeDelete: true);
        }
    }
}
