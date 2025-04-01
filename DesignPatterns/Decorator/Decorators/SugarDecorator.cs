using Decorator.Models.Interfaces;

namespace Decorator.Decorators
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => _coffee.GetDescription() + ", sugar";
        public override double GetCost() => _coffee.GetCost() + 0.5;
    }
}
