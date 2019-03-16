namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesDepartmentSpecialistandInfo : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DepartmentInfoes", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.DepartmentInfoes", new[] { "DepartmentId" });
            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DepartmentCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentCategories", t => t.DepartmentCategoryId, cascadeDelete: true)
                .Index(t => t.DepartmentCategoryId);
            
            CreateTable(
                "dbo.ExpertIns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SpecialityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Specialities", t => t.SpecialityId, cascadeDelete: true)
                .Index(t => t.SpecialityId);
            
            AddColumn("dbo.Departments", "Address", c => c.String());
            AddColumn("dbo.Departments", "Mail", c => c.String());
            AddColumn("dbo.Departments", "Phone", c => c.String());
            DropTable("dbo.DepartmentInfoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DepartmentInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Mail = c.String(),
                        Phone = c.String(),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.ExpertIns", "SpecialityId", "dbo.Specialities");
            DropForeignKey("dbo.Specialities", "DepartmentCategoryId", "dbo.DepartmentCategories");
            DropIndex("dbo.ExpertIns", new[] { "SpecialityId" });
            DropIndex("dbo.Specialities", new[] { "DepartmentCategoryId" });
            DropColumn("dbo.Departments", "Phone");
            DropColumn("dbo.Departments", "Mail");
            DropColumn("dbo.Departments", "Address");
            DropTable("dbo.ExpertIns");
            DropTable("dbo.Specialities");
            CreateIndex("dbo.DepartmentInfoes", "DepartmentId");
            AddForeignKey("dbo.DepartmentInfoes", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
