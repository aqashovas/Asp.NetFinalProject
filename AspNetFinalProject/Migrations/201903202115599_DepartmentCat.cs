namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepartmentCat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "DepartmentCategory_Id", "dbo.DepartmentCategories");
            DropIndex("dbo.Doctors", new[] { "DepartmentCategory_Id" });
            RenameColumn(table: "dbo.Doctors", name: "DepartmentCategory_Id", newName: "DepartmentCategoryId");
            AlterColumn("dbo.Doctors", "DepartmentCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Doctors", "DepartmentCategoryId");
            AddForeignKey("dbo.Doctors", "DepartmentCategoryId", "dbo.DepartmentCategories", "Id", cascadeDelete: true);
            DropColumn("dbo.Doctors", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Doctors", "CategoryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Doctors", "DepartmentCategoryId", "dbo.DepartmentCategories");
            DropIndex("dbo.Doctors", new[] { "DepartmentCategoryId" });
            AlterColumn("dbo.Doctors", "DepartmentCategoryId", c => c.Int());
            RenameColumn(table: "dbo.Doctors", name: "DepartmentCategoryId", newName: "DepartmentCategory_Id");
            CreateIndex("dbo.Doctors", "DepartmentCategory_Id");
            AddForeignKey("dbo.Doctors", "DepartmentCategory_Id", "dbo.DepartmentCategories", "Id");
        }
    }
}
