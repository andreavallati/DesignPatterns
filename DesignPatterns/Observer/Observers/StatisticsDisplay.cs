using Observer.Services.Interfaces;

namespace Observer.Observers
{
    public class StatisticsDisplay : IObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"StatisticsDisplay: Analyzing stats for temperature: {temperature}, humidity: {humidity}, pressure: {pressure}.");
        }
    }
}
