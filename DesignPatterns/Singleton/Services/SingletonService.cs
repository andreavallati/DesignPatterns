using Singleton.Services.Interfaces;

namespace Singleton.Services
{
    public sealed class SingletonService : ISingletonService
    {
        private static readonly Lazy<SingletonService> _instance = new Lazy<SingletonService>(() => new SingletonService());
        private readonly Guid _instanceId;

        private SingletonService()
        {
            _instanceId = Guid.NewGuid();
            Console.WriteLine($"SingletonService created with ID: {_instanceId}");
        }

        public static SingletonService Instance => _instance.Value;

        public void PerformAction()
        {
            Console.WriteLine($"SingletonService with ID: {_instanceId} is performing an action.");
        }
    }
}
