namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateNewRelation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.DeferredPayments", "ClintId", c => c.Guid(nullable: false));
            AddColumn("dbo.Products", "ClintId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Employees", "PassportNumber", c => c.String());
            CreateIndex("dbo.DeferredPayments", "ClintId");
            CreateIndex("dbo.Products", "ClintId");
            AddForeignKey("dbo.DeferredPayments", "ClintId", "dbo.Clints", "Id");
            AddForeignKey("dbo.Products", "ClintId", "dbo.Clints", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ClintId", "dbo.Clints");
            DropForeignKey("dbo.DeferredPayments", "ClintId", "dbo.Clints");
            DropIndex("dbo.Products", new[] { "ClintId" });
            DropIndex("dbo.DeferredPayments", new[] { "ClintId" });
            AlterColumn("dbo.Employees", "PassportNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "ClintId");
            DropColumn("dbo.DeferredPayments", "ClintId");
            DropColumn("dbo.Employees", "Salary");
        }
    }
}
