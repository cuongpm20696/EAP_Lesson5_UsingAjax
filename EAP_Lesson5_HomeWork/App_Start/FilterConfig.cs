﻿using System.Web;
using System.Web.Mvc;

namespace EAP_Lesson5_HomeWork
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
