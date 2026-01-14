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
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Register SingletonService as a singleton in DI container
            // This is the modern, DI-friendly approach to Singleton pattern
            serviceCollection.AddSingleton<ISingletonService, SingletonService>();
            
            serviceCollection.AddTransient<SingletonController>();
        }
    }
}
