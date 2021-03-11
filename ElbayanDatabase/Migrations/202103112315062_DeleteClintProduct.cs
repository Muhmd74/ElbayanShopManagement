namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteClintProduct : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "ClintId", "dbo.Clints");
            DropIndex("dbo.Products", new[] { "ClintId" });
            DropColumn("dbo.Products", "ClintId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ClintId", c => c.Guid(nullable: false));
            CreateIndex("dbo.Products", "ClintId");
            AddForeignKey("dbo.Products", "ClintId", "dbo.Clints", "Id");
        }
    }
}
