using FactoryMethod.Creators.Interfaces;
using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Factories.Interfaces
{
    public interface IDocumentFactory
    {
        IDocument CreateDocument<TDocumentCreator>() where TDocumentCreator : IDocumentCreator;
    }
}
