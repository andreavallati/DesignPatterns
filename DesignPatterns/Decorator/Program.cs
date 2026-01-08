using Decorator.Dependencies;
using Decorator.Services;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = DecoratorConfiguration.ConfigureServices();

var coffeeService = serviceProvider.GetRequiredService<ICoffeeService>();

var firstCoffee = coffeeService.CreateCustomCoffee(true, true, false, false);
Console.WriteLine($"First Coffee Description: {firstCoffee.GetDescription()}");
Console.WriteLine($"First Coffee Cost: {firstCoffee.GetCost()}");

var secondCoffee = coffeeService.CreateCustomCoffee(true, false, false, true);
Console.WriteLine($"Second Coffee Description: {secondCoffee.GetDescription()}");
Console.WriteLine($"Second Coffee Cost: {secondCoffee.GetCost()}");

var thirdCoffee = coffeeService.CreateCustomCoffee(false, false, false, true);
Console.WriteLine($"Third Coffee Description: {thirdCoffee.GetDescription()}");
Console.WriteLine($"Third Coffee Cost: {thirdCoffee.GetCost()}");