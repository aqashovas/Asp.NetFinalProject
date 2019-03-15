using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AspNetFinalProject.Models
{
    public class PromediHospitalContext:DbContext
    {
        public PromediHospitalContext() : base("PromediHospitalContext")
        {

        }
        public DbSet<About> Abouts;

        public DbSet<Author> Authors;

        public DbSet<Appointment> Appointments;

        public DbSet<Blog> Blogs;

        public DbSet<BlogCategory> BlogCategories;

        public DbSet<Blogtag> Blogtags;

        public DbSet<Comment> Comments;

        public DbSet<Counter> Counters;

        public DbSet<Department> Departments;

        public DbSet<DepartmentCategory> DepartmentCategories;

        public DbSet<DepartmentInfo> DepartmentInfos;

        public DbSet<Doctor> Doctors;

        public DbSet<PatientFeedback> PatientFeedbacks;

        public DbSet<Promedi> Promedis;

        public DbSet<Setting> Settings;

        public DbSet<Tag> Tags;














    }
}