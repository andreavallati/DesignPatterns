using Strategy.Interfaces;

namespace Strategy.Context.Interfaces
{
    public interface ITaxCalculatorContext
    {
        decimal CalculateTax<TStrategy>(decimal income) where TStrategy : ITaxStrategy;
    }
}
