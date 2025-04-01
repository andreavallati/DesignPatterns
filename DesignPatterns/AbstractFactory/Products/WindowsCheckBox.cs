using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products
{
    public class WindowsCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a checkbox in Windows style.");
        }
    }
}
