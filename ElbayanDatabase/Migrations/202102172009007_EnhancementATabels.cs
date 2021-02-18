namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnhancementATabels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubCategories", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SubCategories", "IsDeleted");
        }
    }
}
