using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products
{
    public class MacCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a checkbox in Mac style.");
        }
    }
}
