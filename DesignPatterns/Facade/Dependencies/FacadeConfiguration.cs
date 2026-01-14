using Facade.Facades;
using Facade.Facades.Interfaces;
using Facade.Subsystems;
using Microsoft.Extensions.DependencyInjection;

namespace Facade.Dependencies
{
    public static class FacadeConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Register subsystem components
            serviceCollection.AddTransient<DVDPlayer>();
            serviceCollection.AddTransient<Projector>();
            serviceCollection.AddTransient<SoundSystem>();
            serviceCollection.AddTransient<Lights>();

            // Register the facade
            serviceCollection.AddTransient<IHomeTheaterFacade, HomeTheaterFacade>();
        }
    }
}
