namespace Strategy.Strategies.Interfaces
{
    public interface ITaxStrategy
    {
        decimal CalculateTax(decimal income);
    }
}
