﻿using System.Web;
using System.Web.Mvc;

namespace RAD302s00130207
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
