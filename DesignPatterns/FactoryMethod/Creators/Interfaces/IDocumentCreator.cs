using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Creators.Interfaces
{
    public interface IDocumentCreator
    {
        IDocument CreateDocument();
    }
}
