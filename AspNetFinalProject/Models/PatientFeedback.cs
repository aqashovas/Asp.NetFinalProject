using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class PatientFeedback
    {
        public int Id { get; set; }

        [Required]
        public string Photo { get; set; }

        [Required]
        public string Name { get; set; }

        public string Text { get; set; }



    }
}