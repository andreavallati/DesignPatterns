using FactoryMethod.Products;
using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Creators
{
    // Concrete Creator for Word documents
    // Overrides the factory method to return a specific product type
    public class WordDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            Console.WriteLine("Factory Method: Creating Word document instance");
            return new WordDocument();
        }
    }
}
