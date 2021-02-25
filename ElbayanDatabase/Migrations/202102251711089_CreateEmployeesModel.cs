namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEmployeesModel : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        POSId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.POS", t => t.POSId, cascadeDelete: true)
                .Index(t => t.POSId);
            
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
            
            AddForeignKey("dbo.MemberRoles", "RoleId", "dbo.Roles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.EmployeeSalaryActions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.IncreasesSalaries", "ActionSalaryId", "dbo.EmployeeSalaryActions");
            DropForeignKey("dbo.DetectionsSalaries", "ActionSalaryId", "dbo.EmployeeSalaryActions");
            DropForeignKey("dbo.EmployeeSalaries", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EmployeePermissions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.EmployeePermissions", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.CashierDrawers", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Sales", "POSId", "dbo.POS");
            DropForeignKey("dbo.CashierDrawers", "PosId", "dbo.POS");
            DropForeignKey("dbo.DrawerTransactions", "CashierDrawerId", "dbo.CashierDrawers");
            DropForeignKey("dbo.DailyOffShifts", "CashierDrawerId", "dbo.CashierDrawers");
            DropForeignKey("dbo.Commissions", "EmployeeSalaryId", "dbo.EmployeeSalaries");
            DropForeignKey("dbo.Allowances", "EmployeeSalaryId", "dbo.EmployeeSalaries");
            DropIndex("dbo.IncreasesSalaries", new[] { "ActionSalaryId" });
            DropIndex("dbo.DetectionsSalaries", new[] { "ActionSalaryId" });
            DropIndex("dbo.EmployeeSalaryActions", new[] { "EmployeeId" });
            DropIndex("dbo.EmployeePermissions", new[] { "RoleId" });
            DropIndex("dbo.EmployeePermissions", new[] { "EmployeeId" });
            DropIndex("dbo.Sales", new[] { "POSId" });
            DropIndex("dbo.DrawerTransactions", new[] { "CashierDrawerId" });
            DropIndex("dbo.DailyOffShifts", new[] { "CashierDrawerId" });
            DropIndex("dbo.CashierDrawers", new[] { "PosId" });
            DropIndex("dbo.CashierDrawers", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "Email" });
            DropIndex("dbo.Commissions", new[] { "EmployeeSalaryId" });
            DropIndex("dbo.EmployeeSalaries", new[] { "EmployeeId" });
            DropIndex("dbo.Allowances", new[] { "EmployeeSalaryId" });
            DropTable("dbo.IncreasesSalaries");
            DropTable("dbo.DetectionsSalaries");
            DropTable("dbo.EmployeeSalaryActions");
            DropTable("dbo.EmployeePermissions");
            DropTable("dbo.Sales");
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
