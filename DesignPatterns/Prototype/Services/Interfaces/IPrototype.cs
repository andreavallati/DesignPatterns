namespace Prototype.Services.Interfaces
{
    public interface IPrototype<TModel>
    {
        TModel Clone();
    }
}
