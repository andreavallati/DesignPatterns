using FactoryMethod.Creators;
using FactoryMethod.Creators.Interfaces;
using FactoryMethod.Factories;
using FactoryMethod.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Singleton.Dependencies
{
    public static class FactoryMethodConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            // Configure DI services
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            // Build the service provider
            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IDocumentFactory, DocumentFactory>();
            serviceCollection.AddTransient<IDocumentCreator, WordDocumentCreator>();
            serviceCollection.AddTransient<IDocumentCreator, PdfDocumentCreator>();
            serviceCollection.AddTransient<IDocumentCreator, ExcelDocumentCreator>();
            serviceCollection.AddTransient<WordDocumentCreator>();
            serviceCollection.AddTransient<PdfDocumentCreator>();
            serviceCollection.AddTransient<ExcelDocumentCreator>();
        }
    }
}
