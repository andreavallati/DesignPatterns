using Decorator.Models.Interfaces;

namespace Decorator.Decorators
{
    public class WhippedCreamDecorator : CoffeeDecorator
    {
        public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() => _coffee.GetDescription() + ", whipped cream";
        public override double GetCost() => _coffee.GetCost() + 1.0;
    }
}
