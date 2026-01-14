using FactoryMethod.Products;
using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Creators
{
    // Concrete Creator for Excel documents
    // Overrides the factory method to return a specific product type
    public class ExcelDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            Console.WriteLine("Factory Method: Creating Excel document instance");
            return new ExcelDocument();
        }
    }
}
