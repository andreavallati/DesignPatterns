using Builder.Services.Interfaces;

namespace Builder.Services
{
    public class EngineBuilderService : IEngineBuilderService
    {
        public string BuildEngine(string type)
        {
            return $"{type} Engine";
        }
    }
}
