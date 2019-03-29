using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class ActiveTime
    {
        public int Id { get; set; }

        [Required]
        public string Day { get; set; }

        [Required]
        public string Time { get; set; }
    }
}