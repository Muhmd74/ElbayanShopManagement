namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductStockDtoDeleteKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ProductStocks");
            AlterColumn("dbo.ProductStocks", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.ProductStocks", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ProductStocks");
            AlterColumn("dbo.ProductStocks", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.ProductStocks", "Id");
        }
    }
}
