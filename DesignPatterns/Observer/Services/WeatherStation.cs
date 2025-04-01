using Observer.Services.Interfaces;

namespace Observer.Services
{
    public class WeatherStation : IWeatherStation
    {
        private readonly List<IObserver> _observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherStation()
        {
            _observers = [];
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void SetWeatherData(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            NotifyObservers();
        }
    }
}
