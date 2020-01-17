using System;

using R5T.Tromso.Types;


namespace R5T.Tromso.ServiceProvider
{
    public static class ServiceProvider
    {
        public static IServiceBuilder<IServiceProvider> New()
        {
            var buildableServiceProvider = new BuildableServiceProvider();

            var serviceBuilder = buildableServiceProvider.GetServiceBuilder();
            return serviceBuilder;
        }
    }
}
