namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnhancementOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderNumber", c => c.Int(nullable: false));
            AddColumn("dbo.DeferredPayments", "TotalPayment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.DeferredPayments", "CollectingPaymentDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.OrderProducts", "Vat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrderProducts", "Vat", c => c.Int(nullable: false));
            DropColumn("dbo.DeferredPayments", "CollectingPaymentDate");
            DropColumn("dbo.DeferredPayments", "TotalPayment");
            DropColumn("dbo.Orders", "OrderNumber");
        }
    }
}
