namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSupplierDaatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Mobile = c.String(),
                        IdNumber = c.Int(nullable: false),
                        FirmName = c.String(),
                        Address = c.String(),
                        Description = c.String(),
                        CommercialRegister = c.String(),
                        TaxNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        OpeningBalance = c.Int(nullable: false),
                        SupplierNumber = c.Int(nullable: false),
                        CustomerTypeId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerTypes", t => t.CustomerTypeId)
                .Index(t => t.CustomerTypeId);
            
            CreateTable(
                "dbo.SupplierOrders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        SupplierId = c.Guid(nullable: false),
                        SubTotalWithoutDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAfterDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Payment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDeferred = c.Boolean(nullable: false),
                        OrderNumber = c.Int(nullable: false),
                        Deferred = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmployeeId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId)
                .Index(t => t.SupplierId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.SupplierDeferredPayments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        SupplierOrderId = c.Guid(nullable: false),
                        DeferredOfOrder = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Payment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DueDatePayingOff = c.DateTime(nullable: false),
                        CollectingPaymentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SupplierOrders", t => t.SupplierOrderId)
                .Index(t => t.SupplierOrderId);
            
            CreateTable(
                "dbo.SupplierOrderProducts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        ProductId = c.Guid(nullable: false),
                        SupplierOrderId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PriceSale = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.SupplierOrders", t => t.SupplierOrderId)
                .Index(t => t.ProductId)
                .Index(t => t.SupplierOrderId);
            
            AddColumn("dbo.CustomerTypes", "IsSupplier", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Suppliers", "CustomerTypeId", "dbo.CustomerTypes");
            DropForeignKey("dbo.SupplierOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.SupplierOrderProducts", "SupplierOrderId", "dbo.SupplierOrders");
            DropForeignKey("dbo.SupplierOrderProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SupplierDeferredPayments", "SupplierOrderId", "dbo.SupplierOrders");
            DropForeignKey("dbo.SupplierOrders", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.SupplierOrderProducts", new[] { "SupplierOrderId" });
            DropIndex("dbo.SupplierOrderProducts", new[] { "ProductId" });
            DropIndex("dbo.SupplierDeferredPayments", new[] { "SupplierOrderId" });
            DropIndex("dbo.SupplierOrders", new[] { "EmployeeId" });
            DropIndex("dbo.SupplierOrders", new[] { "SupplierId" });
            DropIndex("dbo.Suppliers", new[] { "CustomerTypeId" });
            DropColumn("dbo.CustomerTypes", "IsSupplier");
            DropTable("dbo.SupplierOrderProducts");
            DropTable("dbo.SupplierDeferredPayments");
            DropTable("dbo.SupplierOrders");
            DropTable("dbo.Suppliers");
        }
    }
}
