﻿using System.Web.Mvc;

namespace Thinktecture.AuthorizationServer.WebHost
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}