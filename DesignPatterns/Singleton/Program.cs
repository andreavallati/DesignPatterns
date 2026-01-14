using Microsoft.Extensions.DependencyInjection;
using Singleton.Controllers;
using Singleton.Dependencies;
using Singleton.Services.Interfaces;

// Singleton Pattern - Modern DI Approach
// Purpose: Ensure a class has only one instance and provide global access to it
// Modern approach: Let the DI container manage the singleton lifetime
// Benefits: Better testability, no static dependencies, thread-safe by default

var serviceProvider = SingletonConfiguration.ConfigureServices();

Console.WriteLine("=== Demonstrating Singleton Pattern (DI Approach) ===\n");

// Get the singleton instance from DI container multiple times
Console.WriteLine("First request from DI container:");
var singletonInstance1 = serviceProvider.GetRequiredService<ISingletonService>();
singletonInstance1.PerformAction();

Console.WriteLine("\nSecond request from DI container:");
var singletonInstance2 = serviceProvider.GetRequiredService<ISingletonService>();
singletonInstance2.PerformAction();

Console.WriteLine("\nThird request from DI container:");
var singletonInstance3 = serviceProvider.GetRequiredService<ISingletonService>();
singletonInstance3.PerformAction();

// Verify that all references point to the same instance
Console.WriteLine($"\nAre instance1 and instance2 the same? {ReferenceEquals(singletonInstance1, singletonInstance2)}");
Console.WriteLine($"Are instance2 and instance3 the same? {ReferenceEquals(singletonInstance2, singletonInstance3)}");
Console.WriteLine($"Instance ID verification: {singletonInstance1.GetInstanceId()} == {singletonInstance2.GetInstanceId()} == {singletonInstance3.GetInstanceId()}");

// Use controllers to demonstrate that they all share the same singleton instance
Console.WriteLine("\n=== Using Controllers (with Constructor Injection) ===\n");

var firstController = serviceProvider.GetRequiredService<SingletonController>();
firstController.Execute();

Console.WriteLine();

var secondController = serviceProvider.GetRequiredService<SingletonController>();
secondController.Execute();