using Microsoft.Extensions.DependencyInjection;

namespace Proxy.Dependencies
{
    public static class ProxyConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Proxy pattern doesn't require specific DI registration
            // Proxies are typically created on-demand
            // This is here for consistency with other patterns
        }
    }
}
