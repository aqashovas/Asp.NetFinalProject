namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dateBlog : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Date", c => c.DateTime(nullable: false, storeType: "date"));
            DropColumn("dbo.Blogs", "MoreUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "MoreUrl", c => c.String());
            AlterColumn("dbo.Blogs", "Date", c => c.DateTime(nullable: false));
        }
    }
}
