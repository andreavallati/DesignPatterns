using FactoryMethod.Products;
using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Creators
{
    public class ExcelDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}
