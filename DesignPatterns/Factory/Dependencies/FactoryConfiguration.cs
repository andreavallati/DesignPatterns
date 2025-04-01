using Factory.Factories;
using Factory.Factories.Interfaces;
using Factory.Notifications;
using Factory.Notifications.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Singleton.Dependencies
{
    public static class FactoryConfiguration
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
            serviceCollection.AddSingleton<INotificationServiceFactory, NotificationServiceFactory>();
            serviceCollection.AddTransient<INotificationService, EmailNotification>();
            serviceCollection.AddTransient<INotificationService, SmsNotification>();
            serviceCollection.AddTransient<INotificationService, PushNotification>();
            serviceCollection.AddTransient<EmailNotification>();
            serviceCollection.AddTransient<SmsNotification>();
            serviceCollection.AddTransient<PushNotification>();
        }
    }
}
