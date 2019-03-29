namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoretextBlog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Moretext", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "Moretext");
        }
    }
}
