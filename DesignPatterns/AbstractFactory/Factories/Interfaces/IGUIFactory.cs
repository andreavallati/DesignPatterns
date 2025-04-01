namespace AbstractFactory.Factories.Interfaces
{
    public interface IGUIFactory
    {
        TElement CreateProduct<TElement>() where TElement : class;
    }
}
