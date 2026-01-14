using Factory.Factories;
using Factory.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Factory.Dependencies
{
    public static class FactoryConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);
            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<INotificationServiceFactory, NotificationServiceFactory>();
        }
    }
}
