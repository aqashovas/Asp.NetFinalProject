using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Counter
    {
        public int Id { get; set; }

        public int HappyPatiensCount { get; set; }

        public int ExperiencedDoctorsCount { get; set; }

        public int SuccessfulOperationsCount { get; set; }

        public int BedsCount { get; set; }
    }
}