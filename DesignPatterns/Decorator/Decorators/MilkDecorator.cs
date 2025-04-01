using Decorator.Models.Interfaces;

namespace Decorator.Decorators
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {

        }

        public override string GetDescription() => _coffee.GetDescription() + ", milk";
        public override double GetCost() => _coffee.GetCost() + 1.5;
    }
}
