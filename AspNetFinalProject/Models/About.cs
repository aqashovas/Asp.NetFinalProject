using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class About
    {
        public int Id { get; set; }

        [Required]
        public string Photo { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Title { get; set; }
    }
}