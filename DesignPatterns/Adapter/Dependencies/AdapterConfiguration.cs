using Adapter.Services;
using Adapter.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Adapter.Dependencies
{
    public static class AdapterConfiguration
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
            serviceCollection.AddSingleton<LegacyLogger>();
            serviceCollection.AddSingleton<ILogger, LoggerAdapter>();
        }
    }
}
