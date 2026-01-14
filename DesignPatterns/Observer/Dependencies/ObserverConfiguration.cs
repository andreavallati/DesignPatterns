using Microsoft.Extensions.DependencyInjection;
using Observer.Observers;
using Observer.Services;
using Observer.Services.Interfaces;

namespace Observer.Dependencies
{
    public static class ObserverConfiguration
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
            serviceCollection.AddSingleton<IWeatherStation, WeatherStation>();
            serviceCollection.AddSingleton<IObserver, TemperatureDisplay>();
            serviceCollection.AddSingleton<IObserver, ForecastDisplay>();
            serviceCollection.AddSingleton<IObserver, StatisticsDisplay>();
        }
    }
}
