using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WindowsCheckBox();
        }
    }
}
