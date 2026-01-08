using Builder.Builders;
using Builder.Builders.Interfaces;
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
            // Register builder as transient so each retrieval gets a fresh builder instance
            serviceCollection.AddTransient<ICarBuilder, CarBuilder>();
        }
    }
}
