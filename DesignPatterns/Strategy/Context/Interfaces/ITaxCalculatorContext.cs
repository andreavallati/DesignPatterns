using Strategy.Strategies.Interfaces;

namespace Strategy.Context.Interfaces
{
    public interface ITaxCalculatorContext
    {
        void SetStrategy(ITaxStrategy strategy);
        decimal CalculateTax(decimal income);
    }
}
