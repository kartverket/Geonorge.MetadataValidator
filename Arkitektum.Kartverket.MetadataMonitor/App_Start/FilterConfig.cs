﻿using System.Web;
using System.Web.Mvc;

namespace Arkitektum.Kartverket.MetadataMonitor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}