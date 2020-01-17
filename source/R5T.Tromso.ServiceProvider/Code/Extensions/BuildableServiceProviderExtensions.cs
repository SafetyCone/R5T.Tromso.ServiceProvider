using System;

using R5T.Richmond;


namespace R5T.Tromso.ServiceProvider
{
    public static class BuildableServiceProviderExtensions
    {
        public static IServiceProvider UseStartup<TStartup>(this BuildableServiceProvider buildableServiceProvider, IServiceProvider configurationServiceProvider)
            where TStartup : class, IStartup
        {
            buildableServiceProvider.UseStartup<TStartup>(configurationServiceProvider);

            var serviceProvider = buildableServiceProvider.GetResult();
            return serviceProvider;
        }
    }
}
