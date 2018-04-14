using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Static", action = "Index" }
            );
            routes.MapRoute(
                name: "Products",
                url: "{controller}/{action}",
                defaults: new { controller = "Products", action = "List" }
                );



        }
    }
}
