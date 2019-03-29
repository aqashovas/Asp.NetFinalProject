using AspNetFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.ViewModels
{
    public class VwHome
    {
        public List<Promedi> Promedis { get; set; }

        public Slider Slider1 { get; set; }

        public Slider Slider2 { get; set; }

        public Slider Slider3 { get; set; }

        public List<Doctor> Doctors { get; set; }

        public List<PatientFeedback> PatientFeedbacks { get; set; }

        public About About { get; set; }

        public List<DepartmentCategory> DepartmentCategories { get; set; }

        public Setting Setting { get; set; }

        public List<Counter> Counters { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}