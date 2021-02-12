namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
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
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        CategoryId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        UCP = c.String(),
                        BarCode = c.String(),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        DefaultPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubCategoryId = c.Guid(nullable: false),
                        ProductNumber = c.Long(nullable: false),
                        IsExpired = c.Boolean(nullable: false),
                        LargeUnitId = c.Guid(nullable: false),
                        SmallUnitId = c.Guid(nullable: false),
                        LimitedDemand = c.Int(nullable: false),
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
                        Weight = c.String(),
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
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.MemberRoles", "MemberId", "dbo.Members");
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.Products", "SmallUnitId", "dbo.SmallUnits");
            DropForeignKey("dbo.Products", "LargeUnitId", "dbo.LargeUnits");
            DropIndex("dbo.MemberRoles", new[] { "RoleId" });
            DropIndex("dbo.MemberRoles", new[] { "MemberId" });
            DropIndex("dbo.Products", new[] { "SmallUnitId" });
            DropIndex("dbo.Products", new[] { "LargeUnitId" });
            DropIndex("dbo.Products", new[] { "SubCategoryId" });
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropTable("dbo.Roles");
            DropTable("dbo.Members");
            DropTable("dbo.MemberRoles");
            DropTable("dbo.SmallUnits");
            DropTable("dbo.LargeUnits");
            DropTable("dbo.Products");
            DropTable("dbo.SubCategories");
            DropTable("dbo.Categories");
        }
    }
}
