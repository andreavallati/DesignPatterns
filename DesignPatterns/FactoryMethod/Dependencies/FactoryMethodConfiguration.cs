using FactoryMethod.Creators;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryMethod.Dependencies
{
    public static class FactoryMethodConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Register concrete creators
            // In a real application, you might inject these based on configuration
            serviceCollection.AddTransient<PdfDocumentCreator>();
            serviceCollection.AddTransient<WordDocumentCreator>();
            serviceCollection.AddTransient<ExcelDocumentCreator>();
        }
    }
}
