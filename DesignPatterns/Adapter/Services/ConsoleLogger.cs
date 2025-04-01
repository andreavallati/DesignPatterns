using Adapter.Services.Interfaces;

namespace Adapter.Services
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[ConsoleLogger] {message}");
        }
    }
}
