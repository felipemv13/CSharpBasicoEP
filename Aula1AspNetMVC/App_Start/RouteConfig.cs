﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Aula1AspNetMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // primeiro coloco as ordens mais complexas, da mais complexa pra mais simples
            routes.MapRoute(
                name: "Secundaria",
                url: "{controller}/{action}/{id}/{nome}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional, nome = UrlParameter.Optional }
            );

            // a última rota deve ser a mais padrão
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
