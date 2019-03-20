namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SpecialityId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Doctors", "DepartmentCategoryId", "dbo.DepartmentCategories");
            DropIndex("dbo.Doctors", new[] { "DepartmentCategoryId" });
            RenameColumn(table: "dbo.Doctors", name: "DepartmentCategoryId", newName: "DepartmentCategory_Id");
            AddColumn("dbo.Doctors", "SpecialityId", c => c.Int(nullable: false));
            AlterColumn("dbo.Doctors", "DepartmentCategory_Id", c => c.Int());
            CreateIndex("dbo.Doctors", "SpecialityId");
            CreateIndex("dbo.Doctors", "DepartmentCategory_Id");
            AddForeignKey("dbo.Doctors", "SpecialityId", "dbo.Specialities", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Doctors", "DepartmentCategory_Id", "dbo.DepartmentCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "DepartmentCategory_Id", "dbo.DepartmentCategories");
            DropForeignKey("dbo.Doctors", "SpecialityId", "dbo.Specialities");
            DropIndex("dbo.Doctors", new[] { "DepartmentCategory_Id" });
            DropIndex("dbo.Doctors", new[] { "SpecialityId" });
            AlterColumn("dbo.Doctors", "DepartmentCategory_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Doctors", "SpecialityId");
            RenameColumn(table: "dbo.Doctors", name: "DepartmentCategory_Id", newName: "DepartmentCategoryId");
            CreateIndex("dbo.Doctors", "DepartmentCategoryId");
            AddForeignKey("dbo.Doctors", "DepartmentCategoryId", "dbo.DepartmentCategories", "Id", cascadeDelete: true);
        }
    }
}
