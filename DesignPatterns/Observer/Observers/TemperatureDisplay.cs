using Observer.Services.Interfaces;

namespace Observer.Observers
{
    public class TemperatureDisplay : IObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"TemperatureDisplay: Current temperature is {temperature}°C.");
        }
    }
}
