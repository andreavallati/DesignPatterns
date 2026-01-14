using FactoryMethod.Products;
using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Creators
{
    // Concrete Creator for PDF documents
    // Overrides the factory method to return a specific product type
    public class PdfDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            Console.WriteLine("Factory Method: Creating PDF document instance");
            return new PdfDocument();
        }
    }
}
