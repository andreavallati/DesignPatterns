using Decorator.Models.Interfaces;

namespace Decorator.Services
{
    public interface ICoffeeService
    {
        ICoffee CreateCustomCoffee(bool addMilk, bool addSugar, bool addCaramel, bool addWhippedCream);
    }
}
