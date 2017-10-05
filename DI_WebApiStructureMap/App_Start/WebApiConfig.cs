using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DI_WebApiStructureMap.App_Start;

namespace DI_WebApiStructureMap
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Setup the structure map dependency resolver
            StructuremapWebApi.Start();
        }
    }
}
