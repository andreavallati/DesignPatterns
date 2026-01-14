using Microsoft.Extensions.DependencyInjection;
using TemplateMethod.DataProcessors;

namespace TemplateMethod.Dependencies
{
    public static class TemplateMethodConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Register concrete processors
            serviceCollection.AddTransient<CsvDataProcessor>();
            serviceCollection.AddTransient<JsonDataProcessor>();
            serviceCollection.AddTransient<XmlDataProcessor>();
        }
    }
}
