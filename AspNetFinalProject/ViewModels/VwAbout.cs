using AspNetFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.ViewModels
{
    public class VwAbout
    {
        public About About { get; set; }

        public List<Counter> Counters { get; set; }

        public List<Doctor> Doctors { get; set; }

        //our some services
        public List<Promedi> Promedismini { get; set; }

        //our all services
        public List<Promedi> Promedisall { get; set; }

        public List<PatientFeedback> PatientFeedbacks { get; set; }



    }
}