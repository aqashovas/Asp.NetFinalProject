using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Counter
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Logo { get; set; }

        public int Count { get; set; }
    }
}