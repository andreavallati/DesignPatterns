using Strategy.Strategies.Interfaces;

namespace Strategy.Strategies
{
    public class CanadaTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal income)
        {
            return income * 0.25m; // 25% tax rate for Canada
        }
    }
}
