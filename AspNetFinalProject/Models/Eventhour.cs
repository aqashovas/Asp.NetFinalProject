using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Eventhour
    {
        public int Id { get; set; }

        public string Thepersonincharge { get; set; }

        public string DayTime { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}