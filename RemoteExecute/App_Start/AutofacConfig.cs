using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using RemoteExecute.DataLayer;
using RemoteExecute.Domain;
using RemoteExecute.Stubs;

namespace RemoteExecute
{
    public class AutofacConfig
    {
        public static void RegisterDependencyResolver()
        {
            var builder = new ContainerBuilder();

            // Register your MVC controllers.
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<InMemoryCommandSetRepository>().As<ICommandSetRepository>()
                .SingleInstance();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
