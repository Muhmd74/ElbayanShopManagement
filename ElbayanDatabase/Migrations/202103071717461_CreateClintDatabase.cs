namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateClintDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes");
            DropForeignKey("dbo.SupplierOrders", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.SupplierDeferredPayments", "SupplierOrderId", "dbo.SupplierOrders");
            DropForeignKey("dbo.SupplierOrderProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SupplierOrderProducts", "SupplierOrderId", "dbo.SupplierOrders");
            DropForeignKey("dbo.SupplierOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Suppliers", "CustomerTypeId", "dbo.CustomerTypes");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.Customers", new[] { "CustomerTypeId" });
            DropIndex("dbo.Suppliers", new[] { "CustomerTypeId" });
            DropIndex("dbo.SupplierOrders", new[] { "SupplierId" });
            DropIndex("dbo.SupplierOrders", new[] { "EmployeeId" });
            DropIndex("dbo.SupplierDeferredPayments", new[] { "SupplierOrderId" });
            DropIndex("dbo.SupplierOrderProducts", new[] { "ProductId" });
            DropIndex("dbo.SupplierOrderProducts", new[] { "SupplierOrderId" });
            CreateTable(
                "dbo.Clints",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Mobile = c.String(nullable: false),
                        Phone = c.String(),
                        NationalIdentity = c.Int(nullable: false),
                        FirmName = c.String(),
                        FaxNumber = c.String(),
                        Address = c.String(),
                        Description = c.String(),
                        CommercialRegister = c.String(),
                        TaxNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsSupplier = c.Boolean(nullable: false),
                        IsCustomer = c.Boolean(nullable: false),
                        OpeningBalance = c.Int(nullable: false),
                        ReferenceNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "ClintId", c => c.Guid(nullable: false));
            AddColumn("dbo.Orders", "IsReturn", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "OrderType", c => c.String());
            CreateIndex("dbo.Orders", "ClintId");
            AddForeignKey("dbo.Orders", "ClintId", "dbo.Clints", "Id");
            DropColumn("dbo.Orders", "CustomerId");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerTypes");
            DropTable("dbo.Suppliers");
            DropTable("dbo.SupplierOrders");
            DropTable("dbo.SupplierDeferredPayments");
            DropTable("dbo.SupplierOrderProducts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SupplierOrderProducts",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SupplierDeferredPayments",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        SupplierOrderId = c.Guid(nullable: false),
                        DeferredOfOrder = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Payment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DueDatePayingOff = c.DateTime(nullable: false),
                        CollectingPaymentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SupplierOrders",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        SupplierId = c.Guid(nullable: false),
                        SubTotalWithoutDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAfterDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Payment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDeferred = c.Boolean(nullable: false),
                        OrderNumber = c.Long(nullable: false),
                        Deferred = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmployeeId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        IsSupplier = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Mobile = c.String(),
                        IdNumber = c.Int(nullable: false),
                        ActivityName = c.String(),
                        Address = c.String(),
                        Description = c.String(),
                        CommercialRegister = c.String(),
                        TaxNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        OpeningBalance = c.Int(nullable: false),
                        CustomerNumber = c.Int(nullable: false),
                        CustomerTypeId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Orders", "CustomerId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Orders", "ClintId", "dbo.Clints");
            DropIndex("dbo.Orders", new[] { "ClintId" });
            DropColumn("dbo.Orders", "OrderType");
            DropColumn("dbo.Orders", "IsReturn");
            DropColumn("dbo.Orders", "ClintId");
            DropTable("dbo.Clints");
            CreateIndex("dbo.SupplierOrderProducts", "SupplierOrderId");
            CreateIndex("dbo.SupplierOrderProducts", "ProductId");
            CreateIndex("dbo.SupplierDeferredPayments", "SupplierOrderId");
            CreateIndex("dbo.SupplierOrders", "EmployeeId");
            CreateIndex("dbo.SupplierOrders", "SupplierId");
            CreateIndex("dbo.Suppliers", "CustomerTypeId");
            CreateIndex("dbo.Customers", "CustomerTypeId");
            CreateIndex("dbo.Orders", "CustomerId");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id");
            AddForeignKey("dbo.Suppliers", "CustomerTypeId", "dbo.CustomerTypes", "Id");
            AddForeignKey("dbo.SupplierOrders", "SupplierId", "dbo.Suppliers", "Id");
            AddForeignKey("dbo.SupplierOrderProducts", "SupplierOrderId", "dbo.SupplierOrders", "Id");
            AddForeignKey("dbo.SupplierOrderProducts", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SupplierDeferredPayments", "SupplierOrderId", "dbo.SupplierOrders", "Id");
            AddForeignKey("dbo.SupplierOrders", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes", "Id");
        }
    }
}
