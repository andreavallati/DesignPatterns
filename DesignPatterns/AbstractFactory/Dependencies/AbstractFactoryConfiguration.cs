using AbstractFactory.Factories;
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
            serviceCollection.AddTransient<WindowsFactory>();
            serviceCollection.AddTransient<MacFactory>();
        }
    }
}
