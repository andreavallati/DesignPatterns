using FactoryMethod.Creators.Interfaces;
using FactoryMethod.Factories.Interfaces;
using FactoryMethod.Products.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryMethod.Factories
{
    public class DocumentFactory : IDocumentFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public DocumentFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        public IDocument CreateDocument<TDocumentCreator>() where TDocumentCreator : IDocumentCreator
        {
            var document = _serviceProvider.GetRequiredService<TDocumentCreator>().CreateDocument();

            if (document is null)
            {
                throw new InvalidOperationException("Document type not found.");
            }

            return document;
        }
    }
}
