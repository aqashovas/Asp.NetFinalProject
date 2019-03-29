using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class ExpertIn
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int SpecialityId { get; set; }

        public Speciality Speciality { get; set; }
    }
}