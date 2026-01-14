using Mediator.Mediators;
using Mediator.Mediators.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Mediator.Dependencies
{
    public static class MediatorConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Register the mediator as a singleton since it coordinates all communication
            serviceCollection.AddSingleton<IChatRoomMediator, ChatRoomMediator>();
        }
    }
}
