using AbstractFactory.Enums;
using AbstractFactory.Factories;
using AbstractFactory.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactory.Dependencies
{
    public static class AbstractFactoryConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);
            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Register concrete factories
            serviceCollection.AddTransient<WindowsFactory>();
            serviceCollection.AddTransient<MacFactory>();
        }

        // Helper method to get a factory based on platform selection
        public static IGUIFactory GetFactory(IServiceProvider serviceProvider, PlatformType platform)
        {
            return platform switch
            {
                PlatformType.Windows => serviceProvider.GetRequiredService<WindowsFactory>(),
                PlatformType.Mac => serviceProvider.GetRequiredService<MacFactory>(),
                _ => throw new ArgumentException($"Unknown platform: {platform}")
            };
        }
    }
}
