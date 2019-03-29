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

        [Required]
        public string Photo { get; set; }

        public int AuthorId { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Column(TypeName ="date")]
        public DateTime Date { get; set; }

        public int CategoryId { get; set; }

        [Required]
        public string Slug { get; set; }

        public string Postedby { get; set; }

        public string SpecialText { get; set; }

        [Required]
        public string Moretext { get; set; }

        public BlogCategory BlogCategory { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Tag> Tags { get; set; }

        public List<Blogtag> Blogtags { get; set; }

        public Author Author { get; set; }






    }
}