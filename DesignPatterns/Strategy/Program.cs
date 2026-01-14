using Microsoft.Extensions.DependencyInjection;
using Strategy.Context.Interfaces;
using Strategy.Dependencies;
using Strategy.Strategies;

var serviceProvider = TaxCalculatorConfiguration.ConfigureServices();

// Retrieve the TaxCalculatorContext and strategies from the DI container
var taxCalculator = serviceProvider.GetRequiredService<ITaxCalculatorContext>();
var usaTaxStrategy = serviceProvider.GetRequiredService<UsaTaxStrategy>();
var canadaTaxStrategy = serviceProvider.GetRequiredService<CanadaTaxStrategy>();
var ukTaxStrategy = serviceProvider.GetRequiredService<UkTaxStrategy>();

// Calculate taxes using different strategies (demonstrating runtime strategy switching)
taxCalculator.SetStrategy(usaTaxStrategy);
decimal usaTax = taxCalculator.CalculateTax(1000);

taxCalculator.SetStrategy(canadaTaxStrategy);
decimal canadaTax = taxCalculator.CalculateTax(1000);

taxCalculator.SetStrategy(ukTaxStrategy);
decimal ukTax = taxCalculator.CalculateTax(1000);

// Output results
Console.WriteLine($"USA Tax on $1000: {usaTax:C}");
Console.WriteLine($"Canada Tax on $1000: {canadaTax:C}");
Console.WriteLine($"UK Tax on $1000: {ukTax:C}");