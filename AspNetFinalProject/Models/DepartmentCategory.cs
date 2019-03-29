using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class DepartmentCategory
    {
      
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Logo { get; set; }

        [Required]
        public string Text { get; set; }

        public List<Appointment> Appointments { get; set; }

        public List<Doctor> Doctors { get; set; }

        public List<Speciality> Specialities { get; set; }
    }
}