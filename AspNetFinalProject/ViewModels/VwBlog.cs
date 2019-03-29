using AspNetFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.ViewModels
{
    public class VwBlog
    {
        public List<Blog> Blogs { get; set; }

        public List<BlogCategory> BlogCategories { get; set; }

        //totalpage is for blogs' pagenation
        public int TotalPage { get; set; }

        public List<Blog> LatestBlogs { get; set; }

        public List<Tag> Tags { get; set; }

        //for active page
        public int Page { get; set; }

        public int? Category { get; set; }
    }
}