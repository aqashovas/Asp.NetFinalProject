namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Text = c.String(),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Mail = c.String(),
                        Phone = c.String(),
                        date = c.DateTime(nullable: false),
                        Message = c.String(),
                        DepartmentCategoryId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentCategories", t => t.DepartmentCategoryId, cascadeDelete: true)
                .Index(t => t.DepartmentCategoryId);
            
            CreateTable(
                "dbo.DepartmentCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        Photo = c.String(),
                        Slug = c.String(),
                        CategoryId = c.Int(nullable: false),
                        DepartmentCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentCategories", t => t.DepartmentCategory_Id)
                .Index(t => t.DepartmentCategory_Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        Moretext = c.String(),
                        FullName = c.String(),
                        Photo = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Mail = c.String(),
                        Speciality = c.String(),
                        Degree = c.String(),
                        ExpertIn = c.String(),
                        Slug = c.String(),
                        Facebook = c.String(),
                        Instagram = c.String(),
                        Linkedin = c.String(),
                        Twitter = c.String(),
                        CategoryId = c.Int(nullable: false),
                        DepartmentCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DepartmentCategories", t => t.DepartmentCategory_Id)
                .Index(t => t.DepartmentCategory_Id);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        AuthorId = c.Int(nullable: false),
                        Text = c.String(),
                        Title = c.String(),
                        MoreUrl = c.String(),
                        date = c.DateTime(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        Slug = c.String(),
                        BlogCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.BlogCategories", t => t.BlogCategory_Id)
                .Index(t => t.AuthorId)
                .Index(t => t.BlogCategory_Id);
            
            CreateTable(
                "dbo.BlogCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blogtags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TagId = c.Int(nullable: false),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .Index(t => t.TagId)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Blog_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.Blog_Id)
                .Index(t => t.Blog_Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fullname = c.String(),
                        Email = c.String(nullable: false),
                        CommentText = c.String(),
                        date = c.DateTime(nullable: false),
                        time = c.DateTime(nullable: false),
                        BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
                .Index(t => t.BlogId);
            
            CreateTable(
                "dbo.Counters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HappyPatiensCount = c.Int(nullable: false),
                        ExperiencedDoctorsCount = c.Int(nullable: false),
                        SuccessfulOperationsCount = c.Int(nullable: false),
                        BedsCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PatientFeedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Name = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Promedis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Logo = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logo = c.String(nullable: false),
                        Linkedin = c.String(),
                        Facebook = c.String(),
                        Instagram = c.String(),
                        Twitter = c.String(),
                        GooglePlus = c.String(),
                        Mail = c.String(),
                        Phone = c.String(),
                        Lat = c.String(),
                        Lng = c.String(),
                        Location = c.String(nullable: false),
                        ContactMail1 = c.String(),
                        ContactPhone1 = c.String(),
                        ContactMail2 = c.String(),
                        ContactPhone2 = c.String(),
                        VideoTitle = c.String(),
                        VideoText = c.String(),
                        VideoUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "Blog_Id", "dbo.Blogs");
            DropForeignKey("dbo.Comments", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.Blogtags", "TagId", "dbo.Tags");
            DropForeignKey("dbo.Blogtags", "BlogId", "dbo.Blogs");
            DropForeignKey("dbo.Blogs", "BlogCategory_Id", "dbo.BlogCategories");
            DropForeignKey("dbo.Blogs", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Doctors", "DepartmentCategory_Id", "dbo.DepartmentCategories");
            DropForeignKey("dbo.DepartmentInfoes", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Departments", "DepartmentCategory_Id", "dbo.DepartmentCategories");
            DropForeignKey("dbo.Appointments", "DepartmentCategoryId", "dbo.DepartmentCategories");
            DropIndex("dbo.Comments", new[] { "BlogId" });
            DropIndex("dbo.Tags", new[] { "Blog_Id" });
            DropIndex("dbo.Blogtags", new[] { "BlogId" });
            DropIndex("dbo.Blogtags", new[] { "TagId" });
            DropIndex("dbo.Blogs", new[] { "BlogCategory_Id" });
            DropIndex("dbo.Blogs", new[] { "AuthorId" });
            DropIndex("dbo.Doctors", new[] { "DepartmentCategory_Id" });
            DropIndex("dbo.DepartmentInfoes", new[] { "DepartmentId" });
            DropIndex("dbo.Departments", new[] { "DepartmentCategory_Id" });
            DropIndex("dbo.Appointments", new[] { "DepartmentCategoryId" });
            DropTable("dbo.Settings");
            DropTable("dbo.Promedis");
            DropTable("dbo.PatientFeedbacks");
            DropTable("dbo.Counters");
            DropTable("dbo.Comments");
            DropTable("dbo.Tags");
            DropTable("dbo.Blogtags");
            DropTable("dbo.BlogCategories");
            DropTable("dbo.Blogs");
            DropTable("dbo.Authors");
            DropTable("dbo.Doctors");
            DropTable("dbo.DepartmentInfoes");
            DropTable("dbo.Departments");
            DropTable("dbo.DepartmentCategories");
            DropTable("dbo.Appointments");
            DropTable("dbo.Abouts");
        }
    }
}
