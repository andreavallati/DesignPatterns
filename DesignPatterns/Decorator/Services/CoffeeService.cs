using Decorator.Decorators;
using Decorator.Models.Interfaces;

namespace Decorator.Services
{
    public class CoffeeService : ICoffeeService
    {
        private readonly ICoffee _baseCoffee;

        public CoffeeService(ICoffee baseCoffee)
        {
            _baseCoffee = baseCoffee;
        }

        public ICoffee CreateCustomCoffee(bool addMilk, bool addSugar, bool addCaramel, bool addWhippedCream)
        {
            ICoffee coffee = _baseCoffee;

            if (addMilk)
            {
                coffee = new MilkDecorator(coffee);
            }

            if (addSugar)
            {
                coffee = new SugarDecorator(coffee);
            }

            if (addCaramel)
            {
                coffee = new CaramelDecorator(coffee);
            }

            if (addWhippedCream)
            {
                coffee = new WhippedCreamDecorator(coffee);
            }

            return coffee;
        }
    }
}
