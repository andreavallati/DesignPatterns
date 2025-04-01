using Microsoft.Extensions.DependencyInjection;
using Strategy.Context.Interfaces;
using Strategy.Interfaces;

namespace Strategy.Context
{
    public class TaxCalculatorContext : ITaxCalculatorContext
    {
        private readonly IServiceProvider _serviceProvider;

        public TaxCalculatorContext(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        public decimal CalculateTax<TStrategy>(decimal income) where TStrategy : ITaxStrategy
        {
            var taxStrategy = _serviceProvider.GetRequiredService<TStrategy>();
            if (taxStrategy is null)
            {
                throw new InvalidOperationException("Tax strategy not found.");
            }

            return taxStrategy.CalculateTax(income);
        }
    }
}
