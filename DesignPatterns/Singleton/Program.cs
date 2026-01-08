using Microsoft.Extensions.DependencyInjection;
using Singleton.Controllers;
using Singleton.Dependencies;
using Singleton.Services;

var serviceProvider = SingletonConfiguration.ConfigureServices();

// Demonstrate the Singleton pattern - accessing the same instance multiple times
Console.WriteLine("=== Demonstrating Singleton Pattern ===\n");

// First access to the Singleton instance
Console.WriteLine("First call to Singleton.Instance:");
var singletonInstance1 = SingletonService.Instance;
singletonInstance1.PerformAction();

Console.WriteLine("\nSecond call to Singleton.Instance:");
var singletonInstance2 = SingletonService.Instance;
singletonInstance2.PerformAction();

Console.WriteLine("\nThird call to Singleton.Instance:");
var singletonInstance3 = SingletonService.Instance;
singletonInstance3.PerformAction();

// Verify that all references point to the same instance
Console.WriteLine($"\nAre instance1 and instance2 the same? {ReferenceEquals(singletonInstance1, singletonInstance2)}");
Console.WriteLine($"Are instance2 and instance3 the same? {ReferenceEquals(singletonInstance2, singletonInstance3)}");

// Use controllers to demonstrate that they all share the same singleton instance
Console.WriteLine("\n=== Using Controllers ===\n");

var firstController = serviceProvider.GetRequiredService<SingletonController>();
firstController.Execute();

Console.WriteLine();

var secondController = serviceProvider.GetRequiredService<SingletonController>();
secondController.Execute();

