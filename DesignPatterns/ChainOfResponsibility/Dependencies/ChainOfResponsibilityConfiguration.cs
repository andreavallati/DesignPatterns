using ChainOfResponsibility.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace ChainOfResponsibility.Dependencies
{
    public static class ChainOfResponsibilityConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Register handlers
            serviceCollection.AddTransient<ValidationHandler>();
            serviceCollection.AddTransient<AuthenticationHandler>();
            serviceCollection.AddTransient<RoleHandler>();
            serviceCollection.AddTransient<AuthorizationHandler>();
            serviceCollection.AddTransient<LoggingHandler>();
        }
    }
}
