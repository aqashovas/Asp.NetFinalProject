namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class departmentsociallinks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Facebook", c => c.String());
            AddColumn("dbo.Departments", "Instagram", c => c.String());
            AddColumn("dbo.Departments", "Twitter", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departments", "Twitter");
            DropColumn("dbo.Departments", "Instagram");
            DropColumn("dbo.Departments", "Facebook");
        }
    }
}
