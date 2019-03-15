using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        public string Message { get; set; }

        public int DepartmentCategoryId { get; set; }

        public int DoctorId { get; set; }

        public DepartmentCategory DepartmentCategory { get; set; }



    }
}