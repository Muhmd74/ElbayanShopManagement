namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMovemnetSupplier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DeferredPayments", "PaymentType", c => c.String());
            AddColumn("dbo.DeferredPayments", "DepositNumber", c => c.Long(nullable: false));
            AddColumn("dbo.DeferredPayments", "Description", c => c.String());
            AddColumn("dbo.DeferredPayments", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.DeferredPayments", "PaymentPerMonth");
            DropColumn("dbo.DeferredPayments", "CollectingPaymentDate");
            DropColumn("dbo.ProductPrices", "Sale");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductPrices", "Sale", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.DeferredPayments", "CollectingPaymentDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.DeferredPayments", "PaymentPerMonth", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.DeferredPayments", "CreatedDate");
            DropColumn("dbo.DeferredPayments", "Description");
            DropColumn("dbo.DeferredPayments", "DepositNumber");
            DropColumn("dbo.DeferredPayments", "PaymentType");
        }
    }
}
