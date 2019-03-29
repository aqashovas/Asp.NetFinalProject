namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostedbyBlog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Postedby", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Postedby");
        }
    }
}
