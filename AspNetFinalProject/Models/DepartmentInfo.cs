using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class DepartmentInfo
    {
        public int Id { get; set; }

        public  string Address { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}