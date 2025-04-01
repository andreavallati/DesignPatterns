using Microsoft.Extensions.DependencyInjection;
using Singleton.Controllers;
using Singleton.Services;
using Singleton.Services.Interfaces;

namespace Singleton.Dependencies
{
    public static class SingletonConfiguration
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
            serviceCollection.AddSingleton<ISingletonService, SingletonService>();
            serviceCollection.AddTransient<SingletonController>();
        }
    }
}
