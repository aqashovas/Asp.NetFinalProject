using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Models
{
    public class Blogtag
    {
        public int TagId { get; set; }

        public int BlogId { get; set; }

        public Tag Tag { get; set; }

        public Blog Blog { get; set; }

    }
}