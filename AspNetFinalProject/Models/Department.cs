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

        public string Address { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public string CategoryName { get; set; }

        public string HeadofDepartmentposition { get; set; }

        public string HeadofDepartmentname { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public string Twitter { get; set; }

        public List<Eventhour> Eventhours { get; set; }



        //public int DepartmentCategoryId { get; set; }






    }
}