using Singleton.Services.Interfaces;

namespace Singleton.Services
{
    public class SingletonService : ISingletonService
    {
        private readonly Guid _instanceId;

        public SingletonService()
        {
            _instanceId = Guid.NewGuid();
            Console.WriteLine($"SingletonService created with ID: {_instanceId}");
        }

        public void PerformAction()
        {
            Console.WriteLine($"SingletonService with ID: {_instanceId} is performing an action.");
        }
    }
}
