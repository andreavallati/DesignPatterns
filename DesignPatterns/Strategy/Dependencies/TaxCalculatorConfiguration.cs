using Microsoft.Extensions.DependencyInjection;
using Strategy.Context;
using Strategy.Context.Interfaces;
using Strategy.Strategies;

namespace Strategy.Dependencies
{
    public static class TaxCalculatorConfiguration
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
            serviceCollection.AddTransient<UsaTaxStrategy>();
            serviceCollection.AddTransient<CanadaTaxStrategy>();
            serviceCollection.AddTransient<UkTaxStrategy>();
            serviceCollection.AddSingleton<ITaxCalculatorContext, TaxCalculatorContext>();
        }
    }
}
