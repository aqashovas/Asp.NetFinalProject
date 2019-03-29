using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Moretext { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Photo { get; set; }

        public string BigPhoto { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        [Required]
        public string Degree { get; set; }

        [Required]
        public string Slug { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public string Linkedin { get; set; }

        public string Twitter { get; set; }

        public int SpecialityId { get; set; }

        public Speciality Speciality { get; set; }

    }
}