namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpectextBlog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "SpecialText", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "SpecialText");
        }
    }
}
