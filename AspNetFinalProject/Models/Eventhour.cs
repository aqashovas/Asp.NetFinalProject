using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Eventhour
    {
        public int Id { get; set; }

        [Required]
        public string Thepersonincharge { get; set; }

        [Required]
        public string DayTime { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}