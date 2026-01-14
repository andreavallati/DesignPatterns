using Microsoft.Extensions.DependencyInjection;
using Prototype.Services;
using Prototype.Services.Interfaces;

namespace Prototype.Dependencies
{
    public static class PrototypeConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            // Configure DI services
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            // Build the service provider
            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IRevisionService, RevisionService>();
        }
    }
}
