using Microsoft.Extensions.DependencyInjection;

namespace State.Dependencies
{
    public static class StateConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // State pattern doesn't require DI registration for states
            // States are created dynamically based on transitions
            // This is here for consistency with other patterns
        }
    }
}
