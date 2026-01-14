namespace Observer.Services.Interfaces
{
    public interface IWeatherStation
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
        void SetWeatherData(float temperature, float humidity, float pressure);
    }
}
