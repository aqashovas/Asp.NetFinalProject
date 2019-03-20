using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetFinalProject.Models;

namespace AspNetFinalProject.ViewModels
{
    public class VwDoctor
    {
        public List<Doctor> Doctors { get; set; }
        public Speciality Speciality { get; set; }


    }
}