namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsDeleteToBuilding : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buildings", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Buildings", "IsDeleted");
        }
    }
}
