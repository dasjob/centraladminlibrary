using CentralAdmin.Library.Service.Registry;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralAdmin.Library.Web.Ioc
{
    public static class ApplicationContainer
    {
        private static volatile Container _current;

        /// <summary>
        /// Gets the current instance of the container
        /// </summary>
        public static Container Current => _current;

        /// <summary>
        /// Configures the ApplicationContainer and plugs it into the framework
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> for the Application Domain</param>
        /// <returns></returns>
        internal static IServiceProvider ConfigureApplicationContainer(this IServiceCollection services)
        {
            Configure(services);
            return Current.GetInstance<IServiceProvider>();
        }

        private static void Configure(IServiceCollection services)
        {
            _current = new Container();


            _current.Configure(config =>
            {
                config.Populate(services);

                // Configure Application Registries here
                // i.e. config.AddRegistry<Type>();
                //config.AddRegistry<HttpRegistry>();
                config.AddRegistry<ServiceRegistry>();
                //config.AddRegistry<WebRegistry>();

            });

            //_current.Populate(services);
        }
    }
}
