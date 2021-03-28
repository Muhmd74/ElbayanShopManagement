namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
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
                        UserName = c.String(nullable: false, maxLength: 450),
                        Password = c.String(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Mobile = c.String(nullable: false),
                        Address = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Position = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Identity = c.String(),
                        IdentityExpirationDate = c.DateTime(nullable: false),
                        PassportNumber = c.String(),
                        PassportExpirationDate = c.DateTime(nullable: false),
                        ResidenceType = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Email, unique: true)
                .Index(t => t.UserName, unique: true);
            
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
                        Id = c.Guid(nullable: false, identity: true),
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
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        ClintId = c.Guid(nullable: false),
                        SubTotalWithoutDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAfterDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Payment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDeferred = c.Boolean(nullable: false),
                        IsReturn = c.Boolean(nullable: false),
                        OrderType = c.String(),
                        OrderNumber = c.Long(nullable: false),
                        Deferred = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PosId = c.Guid(nullable: false),
                        EmployeeId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clints", t => t.ClintId)
                .ForeignKey("dbo.POS", t => t.PosId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.ClintId)
                .Index(t => t.PosId)
                .Index(t => t.EmployeeId);
            
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
            
            CreateTable(
                "dbo.DeferredPayments",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        OrderId = c.Guid(nullable: false),
                        DeferredOfOrder = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Payment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentPerMonth = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DueDatePayingOff = c.DateTime(nullable: false),
                        CollectingPaymentDate = c.DateTime(nullable: false),
                        ClintId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clints", t => t.ClintId)
                .ForeignKey("dbo.Orders", t => t.OrderId)
                .Index(t => t.OrderId)
                .Index(t => t.ClintId);
            
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
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
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        UCP = c.Int(nullable: false),
                        BarCode = c.Long(nullable: false),
                        Name = c.String(nullable: false),
                        ImageUrl = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        TotalQuantity = c.Int(nullable: false),
                        Description = c.String(),
                        PurchaseDefaultPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SaleDefaultPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WholesalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsUnitSale = c.Boolean(nullable: false),
                        SubCategoryId = c.Guid(nullable: false),
                        ProductNumber = c.Int(nullable: false),
                        IsExpired = c.Boolean(nullable: false),
                        LargeUnitId = c.Guid(nullable: false),
                        SmallUnitId = c.Guid(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        LimitedDemand = c.Int(nullable: false),
                        Vat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LargeUnits", t => t.LargeUnitId, cascadeDelete: true)
                .ForeignKey("dbo.SmallUnits", t => t.SmallUnitId, cascadeDelete: true)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .Index(t => t.SubCategoryId)
                .Index(t => t.LargeUnitId)
                .Index(t => t.SmallUnitId);
            
            CreateTable(
                "dbo.LargeUnits",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Weight = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SmallUnits",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Weight = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        LargeUnitId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LargeUnits", t => t.LargeUnitId)
                .Index(t => t.LargeUnitId);
            
            CreateTable(
                "dbo.ProductPrices",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        ProcPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProcessType = c.String(),
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
                        DateTime = c.DateTime(nullable: false),
                        Stock = c.Int(nullable: false),
                        OrderId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CategoryId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        EmployeeId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 450),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.RoleTemplates",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        RoleId = c.Guid(nullable: false),
                        TemplateId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Templates", t => t.TemplateId)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .Index(t => t.RoleId)
                .Index(t => t.TemplateId);
            
            CreateTable(
                "dbo.Templates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 450),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);
            
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
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 250),
                        Password = c.String(nullable: false),
                        EmployeeId = c.Guid(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true);
            
            CreateTable(
                "dbo.Firms",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        LogoInvoice = c.String(),
                        Address = c.String(),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        MessageInvoice = c.String(),
                        Mobile = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        NatureWork = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MemberRoles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MemberId = c.Guid(nullable: false),
                        RoleId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.MemberId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        UserName = c.String(),
                        Mobile = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.MemberRoles", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Employees", "Id", "dbo.Users");
            DropForeignKey("dbo.Orders", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EmployeeSalaryActions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.IncreasesSalaries", "ActionSalaryId", "dbo.EmployeeSalaryActions");
            DropForeignKey("dbo.DetectionsSalaries", "ActionSalaryId", "dbo.EmployeeSalaryActions");
            DropForeignKey("dbo.EmployeeSalaries", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EmployeeRoles", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.RoleTemplates", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.RoleTemplates", "TemplateId", "dbo.Templates");
            DropForeignKey("dbo.EmployeeRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.CashierDrawers", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.CashierDrawers", "PosId", "dbo.POS");
            DropForeignKey("dbo.Orders", "PosId", "dbo.POS");
            DropForeignKey("dbo.OrderProducts", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.ProductStocks", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ProductStocks", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.ProductPrices", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderProducts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.SmallUnits", "LargeUnitId", "dbo.LargeUnits");
            DropForeignKey("dbo.Products", "SmallUnitId", "dbo.SmallUnits");
            DropForeignKey("dbo.Products", "LargeUnitId", "dbo.LargeUnits");
            DropForeignKey("dbo.DeferredPayments", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ClintId", "dbo.Clints");
            DropForeignKey("dbo.DeferredPayments", "ClintId", "dbo.Clints");
            DropForeignKey("dbo.POS", "BuildingId", "dbo.Buildings");
            DropForeignKey("dbo.DrawerTransactions", "CashierDrawerId", "dbo.CashierDrawers");
            DropForeignKey("dbo.DailyOffShifts", "CashierDrawerId", "dbo.CashierDrawers");
            DropForeignKey("dbo.Commissions", "EmployeeSalaryId", "dbo.EmployeeSalaries");
            DropForeignKey("dbo.Allowances", "EmployeeSalaryId", "dbo.EmployeeSalaries");
            DropIndex("dbo.MemberRoles", new[] { "RoleId" });
            DropIndex("dbo.MemberRoles", new[] { "MemberId" });
            DropIndex("dbo.Users", new[] { "UserName" });
            DropIndex("dbo.IncreasesSalaries", new[] { "ActionSalaryId" });
            DropIndex("dbo.DetectionsSalaries", new[] { "ActionSalaryId" });
            DropIndex("dbo.EmployeeSalaryActions", new[] { "EmployeeId" });
            DropIndex("dbo.Templates", new[] { "Name" });
            DropIndex("dbo.RoleTemplates", new[] { "TemplateId" });
            DropIndex("dbo.RoleTemplates", new[] { "RoleId" });
            DropIndex("dbo.Roles", new[] { "Name" });
            DropIndex("dbo.EmployeeRoles", new[] { "RoleId" });
            DropIndex("dbo.EmployeeRoles", new[] { "EmployeeId" });
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropIndex("dbo.ProductStocks", new[] { "OrderId" });
            DropIndex("dbo.ProductStocks", new[] { "ProductId" });
            DropIndex("dbo.ProductPrices", new[] { "ProductId" });
            DropIndex("dbo.SmallUnits", new[] { "LargeUnitId" });
            DropIndex("dbo.Products", new[] { "SmallUnitId" });
            DropIndex("dbo.Products", new[] { "LargeUnitId" });
            DropIndex("dbo.Products", new[] { "SubCategoryId" });
            DropIndex("dbo.OrderProducts", new[] { "OrderId" });
            DropIndex("dbo.OrderProducts", new[] { "ProductId" });
            DropIndex("dbo.DeferredPayments", new[] { "ClintId" });
            DropIndex("dbo.DeferredPayments", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "EmployeeId" });
            DropIndex("dbo.Orders", new[] { "PosId" });
            DropIndex("dbo.Orders", new[] { "ClintId" });
            DropIndex("dbo.POS", new[] { "BuildingId" });
            DropIndex("dbo.DrawerTransactions", new[] { "CashierDrawerId" });
            DropIndex("dbo.DailyOffShifts", new[] { "CashierDrawerId" });
            DropIndex("dbo.CashierDrawers", new[] { "PosId" });
            DropIndex("dbo.CashierDrawers", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "UserName" });
            DropIndex("dbo.Employees", new[] { "Email" });
            DropIndex("dbo.Employees", new[] { "Id" });
            DropIndex("dbo.Commissions", new[] { "EmployeeSalaryId" });
            DropIndex("dbo.EmployeeSalaries", new[] { "EmployeeId" });
            DropIndex("dbo.Allowances", new[] { "EmployeeSalaryId" });
            DropTable("dbo.Members");
            DropTable("dbo.MemberRoles");
            DropTable("dbo.Firms");
            DropTable("dbo.Users");
            DropTable("dbo.IncreasesSalaries");
            DropTable("dbo.DetectionsSalaries");
            DropTable("dbo.EmployeeSalaryActions");
            DropTable("dbo.Templates");
            DropTable("dbo.RoleTemplates");
            DropTable("dbo.Roles");
            DropTable("dbo.EmployeeRoles");
            DropTable("dbo.Categories");
            DropTable("dbo.SubCategories");
            DropTable("dbo.ProductStocks");
            DropTable("dbo.ProductPrices");
            DropTable("dbo.SmallUnits");
            DropTable("dbo.LargeUnits");
            DropTable("dbo.Products");
            DropTable("dbo.OrderProducts");
            DropTable("dbo.DeferredPayments");
            DropTable("dbo.Clints");
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
        }
    }
}
