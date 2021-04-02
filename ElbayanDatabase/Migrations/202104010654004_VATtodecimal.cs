namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VATtodecimal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductPrices", "Vat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductPrices", "Vat", c => c.Int(nullable: false));
        }
    }
}
