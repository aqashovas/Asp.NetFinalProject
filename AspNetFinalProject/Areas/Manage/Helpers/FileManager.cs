﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace AspNetFinalProject.Areas.Manage.Helpers
{
    public class FileManager
    {
        public static string Upload(HttpPostedFileBase File)
        {
            string filename = DateTime.Now.ToString("yyyyMMddHHmmssfff") + File.FileName;
            string path = Path.Combine(HttpContext.Current.Server.MapPath("~/Uploads"), filename);
            File.SaveAs(path);

            return filename;
        }

        public static void Delete(string filename)
        {
            string path = Path.Combine(HttpContext.Current.Server.MapPath("~/Uploads"), filename);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}