using AspNetFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.ViewModels
{
    public class VwAppointment
    {
        public List<Doctor> Doctors { get; set; }

        public List<DepartmentCategory> DepartmentCategories { get; set; }

        public Setting Setting { get; set; }
    }
}