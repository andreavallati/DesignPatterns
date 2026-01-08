using Microsoft.Extensions.DependencyInjection;
using Observer.Dependencies;
using Observer.Services.Interfaces;

var serviceProvider = ObserverConfiguration.ConfigureServices();

var weatherStation = serviceProvider.GetRequiredService<IWeatherStation>();

// Register the observers with the weather station
var observers = serviceProvider.GetServices<IObserver>();
foreach (var observer in observers)
{
    weatherStation.RegisterObserver(observer);
}

// Simulate new weather data
weatherStation.SetWeatherData(25.5f, 65.0f, 1013.1f);
weatherStation.SetWeatherData(28.3f, 72.0f, 1009.5f);
weatherStation.SetWeatherData(30.2f, 75.0f, 1005.2f);