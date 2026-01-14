using Singleton.Services.Interfaces;

namespace Singleton.Services
{
    // Singleton Pattern - DI-friendly approach
    // The singleton lifetime is managed by the DI container
    // Register as: services.AddSingleton<ISingletonService, SingletonService>()
    public sealed class SingletonService : ISingletonService
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

        public Guid GetInstanceId() => _instanceId;
    }
}
