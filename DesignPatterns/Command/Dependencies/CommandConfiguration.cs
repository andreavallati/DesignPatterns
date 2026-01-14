using Command.Invokers;
using Command.Invokers.Interfaces;
using Command.Models;
using Microsoft.Extensions.DependencyInjection;

namespace Command.Dependencies
{
    public static class CommandConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Register the receiver
            serviceCollection.AddSingleton<TextDocument>();

            // Register the invoker
            serviceCollection.AddSingleton<ITextEditor, TextEditor>();
        }
    }
}
