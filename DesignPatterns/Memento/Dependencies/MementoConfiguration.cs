using Memento.Caretakers;
using Memento.Originators;
using Microsoft.Extensions.DependencyInjection;

namespace Memento.Dependencies
{
    public static class MementoConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Register document and history
            serviceCollection.AddSingleton<Document>();
            serviceCollection.AddSingleton<DocumentHistory>();
        }
    }
}
