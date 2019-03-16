using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetFinalProject.Models;

namespace AspNetFinalProject.ViewModels
{
    public class VwContact
    {
        public Setting Setting { get; set; }

        public List<ActiveTime> ActiveTimes { get; set; }
    }
}