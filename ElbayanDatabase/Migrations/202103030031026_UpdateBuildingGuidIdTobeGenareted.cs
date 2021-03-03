namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBuildingGuidIdTobeGenareted : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.POS", "BuildingId", "dbo.Buildings");
            DropPrimaryKey("dbo.Buildings");
            AlterColumn("dbo.Buildings", "Id", c => c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"));
            AddPrimaryKey("dbo.Buildings", "Id");
            AddForeignKey("dbo.POS", "BuildingId", "dbo.Buildings", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.POS", "BuildingId", "dbo.Buildings");
            DropPrimaryKey("dbo.Buildings");
            AlterColumn("dbo.Buildings", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Buildings", "Id");
            AddForeignKey("dbo.POS", "BuildingId", "dbo.Buildings", "Id", cascadeDelete: true);
        }
    }
}
