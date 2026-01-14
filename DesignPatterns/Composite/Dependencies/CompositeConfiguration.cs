using Microsoft.Extensions.DependencyInjection;

namespace Composite.Dependencies
{
    public static class CompositeConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Composite pattern doesn't require specific DI registration
            // Components are created on-demand and composed at runtime
            // This is here for consistency with other patterns
        }
    }
}
