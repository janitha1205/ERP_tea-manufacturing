using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ERP_1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Home",
                url: "{Title}",
                defaults: new {controller="Employee",action="Index" }
                );
            routes.MapRoute(
                name: "Material",
                url: "{Title}",
                defaults: new {controller="Material",action="Index", id = UrlParameter.Optional }
                );
            routes.MapRoute(
              name: "Mechine",
              url: "{Title}",
              defaults: new { controller = "Mechine", action = "Index", id = UrlParameter.Optional }
              );
            routes.MapRoute(
              name: "Product",
              url: "{Title}",
              defaults: new { controller = "Product", action = "Index", id = UrlParameter.Optional }
              );
            routes.MapRoute(
              name: "WorkInProgress",
              url: "{Title}",
              defaults: new { controller = "WorkInProgress", action = "Index", id = UrlParameter.Optional }
              );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
