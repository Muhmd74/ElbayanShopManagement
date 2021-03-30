namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUserFromEmployeeModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Id", "dbo.Users");
            DropIndex("dbo.Employees", new[] { "Id" });
            CreateIndex("dbo.Users", "EmployeeId");
            AddForeignKey("dbo.Users", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Users", new[] { "EmployeeId" });
            CreateIndex("dbo.Employees", "Id");
            AddForeignKey("dbo.Employees", "Id", "dbo.Users", "Id");
        }
    }
}
