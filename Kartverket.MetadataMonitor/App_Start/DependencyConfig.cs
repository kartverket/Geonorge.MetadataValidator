using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.WebApi;

namespace Kartverket.MetadataMonitor.App_Start
{
    public static class DependencyConfig
    {
        public static void Configure(ContainerBuilder builder)
        {
            //builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            //builder.RegisterModule(new AutofacWebTypesModule());

            //builder.RegisterType<SearchService>().As<ISearchService>();

            //var container = builder.Build();

            //// dependency resolver for MVC
            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            //// dependency resolver for Web API
            //GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}