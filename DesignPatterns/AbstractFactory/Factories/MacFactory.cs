using AbstractFactory.Factories.Interfaces;
using AbstractFactory.Products;
using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories
{
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }
}
