using FactoryMethod.Creators.Interfaces;
using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Creators
{
    public abstract class DocumentCreator : IDocumentCreator
    {
        public abstract IDocument CreateDocument();
    }
}
