namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class headdepartment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "HeadofDepartmentposition", c => c.String());
            AddColumn("dbo.Departments", "HeadofDepartmentname", c => c.String());
            DropColumn("dbo.Departments", "HeadofDepartment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "HeadofDepartment", c => c.String());
            DropColumn("dbo.Departments", "HeadofDepartmentname");
            DropColumn("dbo.Departments", "HeadofDepartmentposition");
        }
    }
}
