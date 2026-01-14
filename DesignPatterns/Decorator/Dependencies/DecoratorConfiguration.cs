using Decorator.Decorators;
using Decorator.Models;
using Decorator.Models.Interfaces;
using Decorator.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Decorator.Dependencies
{
    public static class DecoratorConfiguration
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
            // Register the base coffee component
            serviceCollection.AddTransient<ICoffee, SimpleCoffee>();

            // Register decorators
            serviceCollection.AddTransient<MilkDecorator>();
            serviceCollection.AddTransient<SugarDecorator>();
            serviceCollection.AddTransient<CaramelDecorator>();
            serviceCollection.AddTransient<WhippedCreamDecorator>();

            // Register CoffeeService
            serviceCollection.AddTransient<ICoffeeService, CoffeeService>();
        }
    }
}
