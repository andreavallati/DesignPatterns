using Observer.Services.Interfaces;

namespace Observer.Observers
{
    public class ForecastDisplay : IObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"ForecastDisplay: Forecast based on pressure {pressure} and humidity {humidity}.");
        }
    }
}
