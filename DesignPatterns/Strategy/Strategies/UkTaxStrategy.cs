using Strategy.Strategies.Interfaces;

namespace Strategy.Strategies
{
    public class UkTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal income)
        {
            return income * 0.20m; // 20% tax rate for UK
        }
    }
}
