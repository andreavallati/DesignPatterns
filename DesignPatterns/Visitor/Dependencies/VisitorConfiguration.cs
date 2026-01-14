using Microsoft.Extensions.DependencyInjection;
using Visitor.Visitors;

namespace Visitor.Dependencies
{
    public static class VisitorConfiguration
    {
        public static ServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();
            Configure(serviceCollection);

            return serviceCollection.BuildServiceProvider();
        }

        private static void Configure(ServiceCollection serviceCollection)
        {
            // Register visitors
            serviceCollection.AddTransient<HtmlExportVisitor>();
            serviceCollection.AddTransient<MarkdownExportVisitor>();
            serviceCollection.AddTransient<WordCountVisitor>();
        }
    }
}
