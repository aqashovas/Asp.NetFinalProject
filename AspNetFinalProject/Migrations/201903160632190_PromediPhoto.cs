namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PromediPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Promedis", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Promedis", "Photo");
        }
    }
}
