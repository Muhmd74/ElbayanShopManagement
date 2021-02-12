namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class enhancementUnit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SmallUnits", "Description", c => c.String());
            AddColumn("dbo.SmallUnits", "IsDeleted", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String());
            DropColumn("dbo.SmallUnits", "IsDeleted");
            DropColumn("dbo.SmallUnits", "Description");
        }
    }
}
