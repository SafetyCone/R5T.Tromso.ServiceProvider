using System;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using R5T.Exeter;
using R5T.Tromso.Types;


namespace R5T.Tromso.ServiceProvider
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Placed the <see cref="BuildableServiceProvider"/> in the base <see cref="R5T.Tromso"/> namespace to simplify client using statment, since adding a reference to this library is enough to indicate a desire to use.
    /// </remarks>
    public class BuildableServiceProvider : IBuildableService
    {
        private IConfigurationBuilder zConfigurationBuilder;
        public IConfigurationBuilder ConfigurationBuilder
        {
            get
            {
                this.zConfigurationBuilder = new ConfigurationBuilder();

                return this.zConfigurationBuilder;
            }
        }
        private IServiceCollection zServiceCollection;
        public IServiceCollection ServiceCollection
        {
            get
            {
                var configuration = this.zConfigurationBuilder.Build();

                this.zServiceCollection = new ServiceCollection()
                    .AddConfiguration(configuration)
                    ;

                return this.zServiceCollection;
            }
        }
        private IServiceProvider zServiceProvider;
        public IServiceProvider ServiceProvider
        {
            get
            {
                this.zServiceProvider = this.zServiceCollection.BuildServiceProvider();

                return this.zServiceProvider;
            }
        }


        public IServiceProvider GetResult()
        {
            return this.zServiceProvider;
        }
    }
}
