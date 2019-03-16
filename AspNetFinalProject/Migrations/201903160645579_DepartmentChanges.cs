namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DepartmentCategories", "Logo", c => c.String());
            AddColumn("dbo.DepartmentCategories", "Text", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DepartmentCategories", "Text");
            DropColumn("dbo.DepartmentCategories", "Logo");
        }
    }
}
