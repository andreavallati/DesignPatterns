using Adapter.Services.Interfaces;

namespace Adapter.Services
{
    public class LoggerAdapter : ILogger
    {
        private readonly LegacyLogger _legacyLogger;

        public LoggerAdapter(LegacyLogger legacyLogger)
        {
            _legacyLogger = legacyLogger ?? throw new ArgumentNullException(nameof(legacyLogger));
        }

        public void Log(string message)
        {
            _legacyLogger.LogToLegacySystem(message);
        }
    }
}
