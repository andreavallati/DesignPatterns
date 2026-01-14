using Decorator.Models.Interfaces;

namespace Decorator.Models
{
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription() => "Simple coffee";
        public double GetCost() => 5.0;
    }
}
