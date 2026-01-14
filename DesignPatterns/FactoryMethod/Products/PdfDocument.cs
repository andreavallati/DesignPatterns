using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Products
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening a PDF document.");
        }
    }
}
