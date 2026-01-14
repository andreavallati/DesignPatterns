using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Products
{
    public class ExcelDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening an Excel document.");
        }
    }
}
