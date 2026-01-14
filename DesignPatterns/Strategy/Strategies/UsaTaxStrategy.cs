using Strategy.Strategies.Interfaces;

namespace Strategy.Strategies
{
    public class UsaTaxStrategy : ITaxStrategy
    {
        public decimal CalculateTax(decimal income)
        {
            return income * 0.30m; // 30% tax rate for USA
        }
    }
}
