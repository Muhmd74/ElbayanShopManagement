namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductModelData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductPrices",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        ProcPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vat = c.Int(nullable: false),
                        Sale = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsBounce = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.ProductStocks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        Stock = c.Int(nullable: false),
                        StockTypeId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StockTypes", t => t.StockTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.StockTypeId);
            
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
            
            AddColumn("dbo.Products", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Products", "UCP", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "BarCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductStocks", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductStocks", "StockTypeId", "dbo.StockTypes");
            DropForeignKey("dbo.ProductPrices", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductStocks", new[] { "StockTypeId" });
            DropIndex("dbo.ProductStocks", new[] { "ProductId" });
            DropIndex("dbo.ProductPrices", new[] { "ProductId" });
            AlterColumn("dbo.Products", "BarCode", c => c.String());
            AlterColumn("dbo.Products", "UCP", c => c.String());
            DropColumn("dbo.Products", "IsDeleted");
            DropColumn("dbo.Products", "DateTime");
            DropTable("dbo.StockTypes");
            DropTable("dbo.ProductStocks");
            DropTable("dbo.ProductPrices");
        }
    }
}
