using System;

using R5T.Richmond;
using R5T.Tromso.Startup;
using R5T.Tromso.Types;


namespace R5T.Tromso.ServiceProvider
{
    public static class BuildableServiceProviderExtensions
    {
        public static IServiceProvider UseStartup<TStartup>(this BuildableServiceProvider buildableServiceProvider, IServiceProvider configurationServiceProvider)
            where TStartup : class, IStartup
        {
            var serviceBuilder = buildableServiceProvider.GetServiceBuilder();

            serviceBuilder.UseStartup<TStartup>();

            serviceBuilder.Build(configurationServiceProvider);

            var serviceProvider = buildableServiceProvider.GetResult();
            return serviceProvider;
        }
    }
}
