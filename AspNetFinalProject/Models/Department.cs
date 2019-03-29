using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Photo { get; set; }

        [Required]
        public string Slug { get; set; }


        public string Address { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        [Required]
        public string CategoryName { get; set; }

        [Required]
        public string HeadofDepartmentposition { get; set; }

        [Required]
        public string HeadofDepartmentname { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public string Twitter { get; set; }

        public List<Eventhour> Eventhours { get; set; }



        //public int DepartmentCategoryId { get; set; }






    }
}