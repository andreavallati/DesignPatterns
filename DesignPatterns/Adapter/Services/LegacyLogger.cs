namespace Adapter.Services
{
    public class LegacyLogger
    {
        public void LogToLegacySystem(string message)
        {
            Console.WriteLine($"[LegacyLogger] {message}");
        }
    }
}
