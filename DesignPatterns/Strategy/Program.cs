// Configure Dependency Injection
using Microsoft.Extensions.DependencyInjection;
using Strategy.Context.Interfaces;
using Strategy.Dependencies;
using Strategy.Strategies;

var serviceProvider = TaxCalculatorConfiguration.ConfigureServices();

// Retrieve the TaxCalculatorContext from the DI container
var taxCalculator = serviceProvider.GetRequiredService<ITaxCalculatorContext>();

// Calculate taxes using different strategies
decimal usaTax = taxCalculator.CalculateTax<UsaTaxStrategy>(1000); // USA tax on $1000
decimal canadaTax = taxCalculator.CalculateTax<CanadaTaxStrategy>(1000); // Canada tax on $1000
decimal ukTax = taxCalculator.CalculateTax<UkTaxStrategy>(1000); // UK tax on $1000

// Output results
Console.WriteLine($"USA Tax on $1000: {usaTax:C}");
Console.WriteLine($"Canada Tax on $1000: {canadaTax:C}");
Console.WriteLine($"UK Tax on $1000: {ukTax:C}");