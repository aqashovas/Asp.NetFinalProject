using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string Photo { get; set; }

        public int AuthorId { get; set; }

        public string Text { get; set; }

        public string Title { get; set; }

        public string MoreUrl { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        public int CategoryId { get; set; }

        public string Slug { get; set; }

        public BlogCategory BlogCategory { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Tag> Tags { get; set; }

        public List<Blogtag> Blogtags { get; set; }

        public Author Author { get; set; }






    }
}