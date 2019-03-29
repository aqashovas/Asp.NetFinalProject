namespace AspNetFinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altertables : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "Photo", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "Text", c => c.String(nullable: false));
            AlterColumn("dbo.Abouts", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.ActiveTimes", "Day", c => c.String(nullable: false));
            AlterColumn("dbo.ActiveTimes", "Time", c => c.String(nullable: false));
            AlterColumn("dbo.DepartmentCategories", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.DepartmentCategories", "Logo", c => c.String(nullable: false));
            AlterColumn("dbo.DepartmentCategories", "Text", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Text", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Moretext", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "FullName", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Photo", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Degree", c => c.String(nullable: false));
            AlterColumn("dbo.Doctors", "Slug", c => c.String(nullable: false));
            AlterColumn("dbo.Specialities", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ExpertIns", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Authors", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Authors", "Photo", c => c.String(nullable: false));
            AlterColumn("dbo.Blogs", "Photo", c => c.String(nullable: false));
            AlterColumn("dbo.Blogs", "Text", c => c.String(nullable: false));
            AlterColumn("dbo.Blogs", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Blogs", "Slug", c => c.String(nullable: false));
            AlterColumn("dbo.Blogs", "Moretext", c => c.String(nullable: false));
            AlterColumn("dbo.BlogCategories", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Tags", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Counters", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Counters", "Logo", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "Text", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "Photo", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "Slug", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "CategoryName", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "HeadofDepartmentposition", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "HeadofDepartmentname", c => c.String(nullable: false));
            AlterColumn("dbo.Eventhours", "Thepersonincharge", c => c.String(nullable: false));
            AlterColumn("dbo.Eventhours", "DayTime", c => c.String(nullable: false));
            AlterColumn("dbo.PatientFeedbacks", "Photo", c => c.String(nullable: false));
            AlterColumn("dbo.PatientFeedbacks", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Promedis", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Promedis", "Logo", c => c.String(nullable: false));
            AlterColumn("dbo.Promedis", "Photo", c => c.String(nullable: false));
            AlterColumn("dbo.Promedis", "Text", c => c.String(nullable: false));
            AlterColumn("dbo.Settings", "Mail", c => c.String(nullable: false));
            AlterColumn("dbo.Settings", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Settings", "Lat", c => c.String(nullable: false));
            AlterColumn("dbo.Settings", "Lng", c => c.String(nullable: false));
            AlterColumn("dbo.Sliders", "Photo", c => c.String(nullable: false));
            AlterColumn("dbo.Sliders", "Text", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sliders", "Text", c => c.String());
            AlterColumn("dbo.Sliders", "Photo", c => c.String());
            AlterColumn("dbo.Settings", "Lng", c => c.String());
            AlterColumn("dbo.Settings", "Lat", c => c.String());
            AlterColumn("dbo.Settings", "Phone", c => c.String());
            AlterColumn("dbo.Settings", "Mail", c => c.String());
            AlterColumn("dbo.Promedis", "Text", c => c.String());
            AlterColumn("dbo.Promedis", "Photo", c => c.String());
            AlterColumn("dbo.Promedis", "Logo", c => c.String());
            AlterColumn("dbo.Promedis", "Name", c => c.String());
            AlterColumn("dbo.PatientFeedbacks", "Name", c => c.String());
            AlterColumn("dbo.PatientFeedbacks", "Photo", c => c.String());
            AlterColumn("dbo.Eventhours", "DayTime", c => c.String());
            AlterColumn("dbo.Eventhours", "Thepersonincharge", c => c.String());
            AlterColumn("dbo.Departments", "HeadofDepartmentname", c => c.String());
            AlterColumn("dbo.Departments", "HeadofDepartmentposition", c => c.String());
            AlterColumn("dbo.Departments", "CategoryName", c => c.String());
            AlterColumn("dbo.Departments", "Slug", c => c.String());
            AlterColumn("dbo.Departments", "Photo", c => c.String());
            AlterColumn("dbo.Departments", "Text", c => c.String());
            AlterColumn("dbo.Departments", "Title", c => c.String());
            AlterColumn("dbo.Counters", "Logo", c => c.String());
            AlterColumn("dbo.Counters", "Name", c => c.String());
            AlterColumn("dbo.Tags", "Name", c => c.String());
            AlterColumn("dbo.BlogCategories", "Name", c => c.String());
            AlterColumn("dbo.Blogs", "Moretext", c => c.String());
            AlterColumn("dbo.Blogs", "Slug", c => c.String());
            AlterColumn("dbo.Blogs", "Title", c => c.String());
            AlterColumn("dbo.Blogs", "Text", c => c.String());
            AlterColumn("dbo.Blogs", "Photo", c => c.String());
            AlterColumn("dbo.Authors", "Photo", c => c.String());
            AlterColumn("dbo.Authors", "Name", c => c.String());
            AlterColumn("dbo.ExpertIns", "Name", c => c.String());
            AlterColumn("dbo.Specialities", "Name", c => c.String());
            AlterColumn("dbo.Doctors", "Slug", c => c.String());
            AlterColumn("dbo.Doctors", "Degree", c => c.String());
            AlterColumn("dbo.Doctors", "Photo", c => c.String());
            AlterColumn("dbo.Doctors", "FullName", c => c.String());
            AlterColumn("dbo.Doctors", "Moretext", c => c.String());
            AlterColumn("dbo.Doctors", "Text", c => c.String());
            AlterColumn("dbo.DepartmentCategories", "Text", c => c.String());
            AlterColumn("dbo.DepartmentCategories", "Logo", c => c.String());
            AlterColumn("dbo.DepartmentCategories", "Name", c => c.String());
            AlterColumn("dbo.ActiveTimes", "Time", c => c.String());
            AlterColumn("dbo.ActiveTimes", "Day", c => c.String());
            AlterColumn("dbo.Abouts", "Title", c => c.String());
            AlterColumn("dbo.Abouts", "Text", c => c.String());
            AlterColumn("dbo.Abouts", "Photo", c => c.String());
        }
    }
}
