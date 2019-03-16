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
        public DbSet<About> Abouts { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<BlogCategory> BlogCategories { get; set; }

        public DbSet<Blogtag> Blogtags { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Counter> Counters { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<DepartmentCategory> DepartmentCategories { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<PatientFeedback> PatientFeedbacks { get; set; }

        public DbSet<Promedi> Promedis { get; set; }

        public DbSet<Setting> Settings { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Speciality> Specialities { get; set; }

        public DbSet<ExpertIn> ExpertIns { get; set; }

        public DbSet<ActiveTime> ActiveTimes { get; set; }














    }
}