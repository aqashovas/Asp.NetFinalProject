using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Doctor
    {
        public int Id { get; set; }        

        public string Text { get; set; }

        public string Moretext { get; set; }

        public string FullName { get; set; }

        public string Photo { get; set; }

        public string BigPhoto { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }
      
        public string Degree { get; set; }

        public string Slug { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public string Linkedin { get; set; }

        public string Twitter { get; set; }

        public int SpecialityId { get; set; }

        public Speciality Speciality { get; set; }

    }
}