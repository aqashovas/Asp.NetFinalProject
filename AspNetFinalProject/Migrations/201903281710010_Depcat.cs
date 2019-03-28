namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Depcat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "DepartmentCategory_Id", "dbo.DepartmentCategories");
            DropIndex("dbo.Departments", new[] { "DepartmentCategory_Id" });
            AddColumn("dbo.Departments", "CategoryName", c => c.String());
            DropColumn("dbo.Departments", "CategoryId");
            DropColumn("dbo.Departments", "DepartmentCategory_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "DepartmentCategory_Id", c => c.Int());
            AddColumn("dbo.Departments", "CategoryId", c => c.Int(nullable: false));
            DropColumn("dbo.Departments", "CategoryName");
            CreateIndex("dbo.Departments", "DepartmentCategory_Id");
            AddForeignKey("dbo.Departments", "DepartmentCategory_Id", "dbo.DepartmentCategories", "Id");
        }
    }
}
