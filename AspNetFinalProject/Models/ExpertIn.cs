using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class ExpertIn
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SpecialityId { get; set; }

        public Speciality Speciality { get; set; }
    }
}