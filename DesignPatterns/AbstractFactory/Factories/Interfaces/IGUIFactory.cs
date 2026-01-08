using AbstractFactory.Products.Interfaces;

namespace AbstractFactory.Factories.Interfaces
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }
}
