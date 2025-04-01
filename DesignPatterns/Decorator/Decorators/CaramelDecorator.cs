using Decorator.Models.Interfaces;

namespace Decorator.Decorators
{
    public class CaramelDecorator : CoffeeDecorator
    {
        public CaramelDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => _coffee.GetDescription() + ", caramel";
        public override double GetCost() => _coffee.GetCost() + 2.0;
    }
}
