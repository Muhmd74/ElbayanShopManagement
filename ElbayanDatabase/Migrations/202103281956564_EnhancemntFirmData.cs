namespace ElbayanDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EnhancemntFirmData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Firms", "Mobile", c => c.Int(nullable: false));
            AlterColumn("dbo.Firms", "Phone", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Firms", "Phone", c => c.String());
            AlterColumn("dbo.Firms", "Mobile", c => c.String());
        }
    }
}
