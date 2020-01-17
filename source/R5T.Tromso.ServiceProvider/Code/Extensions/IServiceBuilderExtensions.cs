using System;

using R5T.Richmond;
using R5T.Tromso.Startup;


namespace R5T.Tromso.ServiceProvider
{
    public static class IServiceBuilderExtensions
    {
        public static IServiceProvider BuildServiceProvider(this IServiceBuilder serviceBuilder, IServiceProvider configurationServiceProvider)
        {
            var buildableServiceProvider = new BuildableServiceProvider();

            serviceBuilder.Build(buildableServiceProvider, configurationServiceProvider);

            var outputServiceProvider = buildableServiceProvider.GetResult();
            return outputServiceProvider;
        }

        public static IServiceProvider UseStartup<TStartup>(this IServiceBuilder serviceBuilder, IServiceProvider configurationServiceProvider)
            where TStartup : class, IStartup
        {
            serviceBuilder.UseStartup<TStartup>();

            var serviceProvider = serviceBuilder.BuildServiceProvider(configurationServiceProvider);
            return serviceProvider;
        }
    }
}
