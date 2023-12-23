using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace firstproject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes(); //enable attribute route

         routes.MapRoute(
         name: "display",
         url: "display/{cid}",
         constraints: new {cid=@"\d{1,3}"},
         defaults: new { controller = "Contact", action = "Show", id = UrlParameter.Optional }
     );

            routes.MapRoute(
              name: "Contact",
              url: "contact",
              defaults: new { controller = "Item", action = "Index", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );
            
        }
    }
}
