using Microsoft.Extensions.DependencyInjection;
using Singleton.Controllers;

namespace Singleton.Dependencies
{
    public static class SingletonConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<SingletonController>();
        }
    }
}
