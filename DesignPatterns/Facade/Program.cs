using Facade.Dependencies;
using Facade.Facades.Interfaces;
using Microsoft.Extensions.DependencyInjection;

// Facade Pattern
// Purpose: Provides a simplified interface to a complex subsystem of classes
// Use case: When you want to provide a simple interface to a complex system
// Benefits: Reduces complexity for clients, promotes loose coupling

var serviceProvider = FacadeConfiguration.ConfigureServices();

var homeTheater = serviceProvider.GetRequiredService<IHomeTheaterFacade>();

Console.WriteLine("=== Facade Pattern Demo ===");
Console.WriteLine("Simplifying the home theater system interaction\n");

// Without facade, we would need to call many methods on multiple objects
// With facade, we just call one simple method
homeTheater.WatchMovie("Inception");

Console.WriteLine("\nPress any key to end the movie...");
Console.ReadKey();

homeTheater.EndMovie();