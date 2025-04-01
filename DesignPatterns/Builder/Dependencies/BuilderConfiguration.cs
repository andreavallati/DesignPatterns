using Builder.Builders;
using Builder.Builders.Interfaces;
using Builder.Services;
using Builder.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Adapter.Dependencies
{
    public static class BuilderConfiguration
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
            serviceCollection.AddSingleton<IEngineBuilderService, EngineBuilderService>();
            serviceCollection.AddSingleton<IGPSService, GPSService>();
            serviceCollection.AddTransient<ICarBuilder, CarBuilder>();
        }
    }
}
