using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        public string Photo { get; set; }

        public string Slug { get; set; }

        public int CategoryId { get; set; }

        public DepartmentCategory DepartmentCategory { get; set; }

        public List<DepartmentInfo> DepartmentInfos { get; set; }

        


    }
}