using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Speciality
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DepartmentCategoryId { get; set; }

        public DepartmentCategory DepartmentCategory { get; set; }

        public List<ExpertIn> ExpertIns { get; set; }

    }
}