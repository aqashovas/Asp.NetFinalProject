using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AspNetFinalProject.Models
{
    public class Setting
    {
        public int Id { get; set; }

        [Required]
        public string Logo { get; set; }

        public string Linkedin { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public string Twitter { get; set; }

        public string GooglePlus { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Lat { get; set; }

        [Required]
        public string Lng { get; set; }

        [Required]
        public string Location { get; set; }

        public string ContactMail1 { get; set; }

        public string ContactPhone1 { get; set; }

        public string ContactMail2 { get; set; }

        public string ContactPhone2 { get; set; }

        //public string VideoTitle { get; set; }

        //public string VideoText { get; set; }

        //public string VideoUrl { get; set; }







    }
}