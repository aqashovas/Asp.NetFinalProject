using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        
        public string Fullname { get; set; }

        [Required]
        public string Email { get; set; }

        public string CommentText { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("time")]
        public DateTime Time { get; set; }

        public int BlogId { get; set; }

        public Blog Blog { get; set; }


    }
}