using System;


namespace R5T.Tromso.ServiceProvider
{
    public static class ServiceProvider
    {
        public static BuildableServiceProvider New()
        {
            var buildableServiceProvider = new BuildableServiceProvider();
            return buildableServiceProvider;
        }
    }
}
