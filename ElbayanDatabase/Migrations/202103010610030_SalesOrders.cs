﻿namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalesOrders : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MemberRoles", "RoleId", "dbo.Roles");
            CreateTable(
                "dbo.Allowances",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Value = c.String(),
                        EmployeeSalaryId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployeeSalaries", t => t.EmployeeSalaryId)
                .Index(t => t.EmployeeSalaryId);
            
            CreateTable(
                "dbo.EmployeeSalaries",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        BasicSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmployeeId = c.Guid(nullable: false),
                        TotalSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Commissions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Value = c.String(),
                        EmployeeSalaryId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployeeSalaries", t => t.EmployeeSalaryId)
                .Index(t => t.EmployeeSalaryId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 450),
                        Password = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Mobile = c.String(nullable: false),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Position = c.String(),
                        Identity = c.String(),
                        IdentityExpirationDate = c.DateTime(nullable: false),
                        PassportNumber = c.Int(nullable: false),
                        PassportExpirationDate = c.DateTime(nullable: false),
                        ResidenceType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true);
            
            CreateTable(
                "dbo.CashierDrawers",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Location = c.String(),
                        EmployeeId = c.Guid(nullable: false),
                        PosId = c.Guid(nullable: false),
                        DrawerBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.POS", t => t.PosId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.PosId);
            
            CreateTable(
                "dbo.DailyOffShifts",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        EndShift = c.DateTime(nullable: false),
                        TotalMoneyOffShift = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CashierDrawerId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CashierDrawers", t => t.CashierDrawerId)
                .Index(t => t.CashierDrawerId);
            
            CreateTable(
                "dbo.DrawerTransactions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Type = c.String(),
                        CashierDrawerId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CashierDrawers", t => t.CashierDrawerId)
                .Index(t => t.CashierDrawerId);
            
            CreateTable(
                "dbo.POS",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        BuildingId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buildings", t => t.BuildingId, cascadeDelete: true)
                .Index(t => t.BuildingId);
            
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        Description = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        CustomerId = c.Guid(nullable: false),
                        SubTotalWithoutDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAfterDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Payment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDeferred = c.Boolean(nullable: false),
                        OrderNumber = c.Long(nullable: false),
                        Deferred = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PosId = c.Guid(nullable: false),
                        EmployeeId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.POS", t => t.PosId)
                .Index(t => t.CustomerId)
                .Index(t => t.PosId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerTypes", t => t.CustomerTypeId)
                .Index(t => t.CustomerTypeId);
            
            CreateTable(
                "dbo.CustomerTypes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        IsSupplier = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                        OrderNumber = c.Long(nullable: false),
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
            
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        ProductId = c.Guid(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PriceSale = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.DeferredPayments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        OrderId = c.Guid(nullable: false),
                        DeferredOfOrder = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Payment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DueDatePayingOff = c.DateTime(nullable: false),
                        CollectingPaymentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.EmployeePermissions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        EmployeeId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.EmployeeSalaryActions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        EntryCode = c.String(),
                        EmployeeId = c.Guid(nullable: false),
                        MonthName = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        TotalMonthlyPaidSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.DetectionsSalaries",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        ActionSalaryId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployeeSalaryActions", t => t.ActionSalaryId)
                .Index(t => t.ActionSalaryId);
            
            CreateTable(
                "dbo.IncreasesSalaries",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        ActionSalaryId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EmployeeSalaryActions", t => t.ActionSalaryId)
                .Index(t => t.ActionSalaryId);
            
            AddColumn("dbo.Products", "TotalQuantity", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Vat", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Discount", c => c.Int(nullable: false));
            AddForeignKey("dbo.MemberRoles", "RoleId", "dbo.Roles", "Id");
            DropColumn("dbo.ProductStocks", "StockTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductStocks", "StockTypeId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.MemberRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.EmployeeSalaryActions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.IncreasesSalaries", "ActionSalaryId", "dbo.EmployeeSalaryActions");
            DropForeignKey("dbo.DetectionsSalaries", "ActionSalaryId", "dbo.EmployeeSalaryActions");
            DropForeignKey("dbo.EmployeeSalaries", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EmployeePermissions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EmployeePermissions", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.CashierDrawers", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.CashierDrawers", "PosId", "dbo.POS");
            DropForeignKey("dbo.Orders", "PosId", "dbo.POS");
            DropForeignKey("dbo.OrderProducts", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.DeferredPayments", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Suppliers", "CustomerTypeId", "dbo.CustomerTypes");
            DropForeignKey("dbo.SupplierOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.SupplierOrderProducts", "SupplierOrderId", "dbo.SupplierOrders");
            DropForeignKey("dbo.SupplierOrderProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SupplierDeferredPayments", "SupplierOrderId", "dbo.SupplierOrders");
            DropForeignKey("dbo.SupplierOrders", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Customers", "CustomerTypeId", "dbo.CustomerTypes");
            DropForeignKey("dbo.POS", "BuildingId", "dbo.Buildings");
            DropForeignKey("dbo.DrawerTransactions", "CashierDrawerId", "dbo.CashierDrawers");
            DropForeignKey("dbo.DailyOffShifts", "CashierDrawerId", "dbo.CashierDrawers");
            DropForeignKey("dbo.Commissions", "EmployeeSalaryId", "dbo.EmployeeSalaries");
            DropForeignKey("dbo.Allowances", "EmployeeSalaryId", "dbo.EmployeeSalaries");
            DropIndex("dbo.IncreasesSalaries", new[] { "ActionSalaryId" });
            DropIndex("dbo.DetectionsSalaries", new[] { "ActionSalaryId" });
            DropIndex("dbo.EmployeeSalaryActions", new[] { "EmployeeId" });
            DropIndex("dbo.EmployeePermissions", new[] { "RoleId" });
            DropIndex("dbo.EmployeePermissions", new[] { "EmployeeId" });
            DropIndex("dbo.DeferredPayments", new[] { "OrderId" });
            DropIndex("dbo.OrderProducts", new[] { "OrderId" });
            DropIndex("dbo.OrderProducts", new[] { "ProductId" });
            DropIndex("dbo.SupplierOrderProducts", new[] { "SupplierOrderId" });
            DropIndex("dbo.SupplierOrderProducts", new[] { "ProductId" });
            DropIndex("dbo.SupplierDeferredPayments", new[] { "SupplierOrderId" });
            DropIndex("dbo.SupplierOrders", new[] { "EmployeeId" });
            DropIndex("dbo.SupplierOrders", new[] { "SupplierId" });
            DropIndex("dbo.Suppliers", new[] { "CustomerTypeId" });
            DropIndex("dbo.Customers", new[] { "CustomerTypeId" });
            DropIndex("dbo.Orders", new[] { "EmployeeId" });
            DropIndex("dbo.Orders", new[] { "PosId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropIndex("dbo.POS", new[] { "BuildingId" });
            DropIndex("dbo.DrawerTransactions", new[] { "CashierDrawerId" });
            DropIndex("dbo.DailyOffShifts", new[] { "CashierDrawerId" });
            DropIndex("dbo.CashierDrawers", new[] { "PosId" });
            DropIndex("dbo.CashierDrawers", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "Email" });
            DropIndex("dbo.Commissions", new[] { "EmployeeSalaryId" });
            DropIndex("dbo.EmployeeSalaries", new[] { "EmployeeId" });
            DropIndex("dbo.Allowances", new[] { "EmployeeSalaryId" });
            DropColumn("dbo.Products", "Discount");
            DropColumn("dbo.Products", "Vat");
            DropColumn("dbo.Products", "TotalQuantity");
            DropTable("dbo.IncreasesSalaries");
            DropTable("dbo.DetectionsSalaries");
            DropTable("dbo.EmployeeSalaryActions");
            DropTable("dbo.EmployeePermissions");
            DropTable("dbo.DeferredPayments");
            DropTable("dbo.OrderProducts");
            DropTable("dbo.SupplierOrderProducts");
            DropTable("dbo.SupplierDeferredPayments");
            DropTable("dbo.SupplierOrders");
            DropTable("dbo.Suppliers");
            DropTable("dbo.CustomerTypes");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.Buildings");
            DropTable("dbo.POS");
            DropTable("dbo.DrawerTransactions");
            DropTable("dbo.DailyOffShifts");
            DropTable("dbo.CashierDrawers");
            DropTable("dbo.Employees");
            DropTable("dbo.Commissions");
            DropTable("dbo.EmployeeSalaries");
            DropTable("dbo.Allowances");
            AddForeignKey("dbo.MemberRoles", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
        }
    }
}
