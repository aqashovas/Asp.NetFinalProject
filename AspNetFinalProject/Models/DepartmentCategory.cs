using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class DepartmentCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public string Text { get; set; }

        public List<Department> Departments { get; set; }

        public List<Appointment> Appointments { get; set; }

        public List<Doctor> Doctors { get; set; }

        public List<Speciality> Specialities { get; set; }
    }
}