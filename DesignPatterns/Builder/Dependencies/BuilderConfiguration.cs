using Builder.Builders;
using Builder.Builders.Interfaces;
using Builder.Services;
using Builder.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Builder.Dependencies
{
    public static class BuilderConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);
            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IEngineBuilderService, EngineBuilderService>();
            serviceCollection.AddSingleton<IGPSService, GPSService>();
            // Changed to Transient so each build gets a fresh builder instance
            serviceCollection.AddTransient<ICarBuilder, CarBuilder>();
        }
    }
}
