namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class videodel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Settings", "VideoTitle");
            DropColumn("dbo.Settings", "VideoText");
            DropColumn("dbo.Settings", "VideoUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "VideoUrl", c => c.String());
            AddColumn("dbo.Settings", "VideoText", c => c.String());
            AddColumn("dbo.Settings", "VideoTitle", c => c.String());
        }
    }
}
