using AbstractFactory.Factories;
using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products;
using Microsoft.Extensions.DependencyInjection;

namespace Singleton.Dependencies
{
    public static class AbstractFactoryConfiguration
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
            serviceCollection.AddSingleton<IGUIFactory, WindowsFactory>();
            serviceCollection.AddSingleton<IGUIFactory, MacFactory>();
            serviceCollection.AddTransient<WindowsFactory>();
            serviceCollection.AddTransient<WindowsButton>();
            serviceCollection.AddTransient<WindowsCheckBox>();
            serviceCollection.AddTransient<MacFactory>();
            serviceCollection.AddTransient<MacButton>();
            serviceCollection.AddTransient<MacCheckBox>();
        }
    }
}
