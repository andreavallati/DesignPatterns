using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Products
{
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a button in Windows style.");
        }
    }
}
