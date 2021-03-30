namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductNumberUCPType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "UCP", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "UCP", c => c.Int(nullable: false));
        }
    }
}
