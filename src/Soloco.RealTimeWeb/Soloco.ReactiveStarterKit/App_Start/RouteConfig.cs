﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Soloco.RealTimeWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(name: "Default", url: "", defaults: new { controller = "Home", action = "Index" });
            routes.MapRoute(name: "Account", url: "Account/{action}", defaults: new { controller = "Account" });
        }
    }
}
