﻿using System.Web;
using System.Web.Mvc;

namespace Tarea2UploadingFiles
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}