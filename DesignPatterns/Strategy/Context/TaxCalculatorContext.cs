using Strategy.Context.Interfaces;
using Strategy.Strategies.Interfaces;

namespace Strategy.Context
{
    public class TaxCalculatorContext : ITaxCalculatorContext
    {
        private ITaxStrategy? _taxStrategy;

        public void SetStrategy(ITaxStrategy strategy)
        {
            _taxStrategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public decimal CalculateTax(decimal income)
        {
            if (_taxStrategy == null)
            {
                throw new InvalidOperationException("Tax strategy has not been set.");
            }

            return _taxStrategy.CalculateTax(income);
        }
    }
}
