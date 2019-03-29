using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Promedi
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Logo { get; set; }

        [Required]
        public string Photo { get; set; }

        [Required]
        public string Text { get; set; }



    }
}