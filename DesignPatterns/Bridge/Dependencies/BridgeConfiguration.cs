using Bridge.Implementors;
using Microsoft.Extensions.DependencyInjection;

namespace Bridge.Dependencies
{
    public static class BridgeConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Register devices
            serviceCollection.AddTransient<TV>();
            serviceCollection.AddTransient<Radio>();
        }
    }
}
