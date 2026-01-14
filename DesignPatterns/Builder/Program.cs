using Builder.Builders.Interfaces;
using Builder.Dependencies;
using Builder.Models;
using Microsoft.Extensions.DependencyInjection;

// Builder Pattern
// Purpose: Separate the construction of a complex object from its representation
// Use case: When an object needs many optional parameters or complex initialization
// Benefits: Improves code readability and allows step-by-step construction

var serviceProvider = BuilderConfiguration.ConfigureServices();

Console.WriteLine("=== Builder Pattern Demo ===\n");

// Get a new builder instance for the first car
var carBuilder1 = serviceProvider.GetRequiredService<ICarBuilder>();

Car sportsCar = carBuilder1
    .SetEngine("V8")
    .SetSeats(2)
    .SetGPS()
    .SetTransmission("Automatic")
    .Build();

Console.WriteLine("Sports Car:");
Console.WriteLine(sportsCar);
Console.WriteLine();

// Get a new builder instance for the second car
var carBuilder2 = serviceProvider.GetRequiredService<ICarBuilder>();

Car suv = carBuilder2
    .SetEngine("V6")
    .SetSeats(7)
    .SetGPS()
    .SetTransmission("Manual")
    .Build();

Console.WriteLine("SUV:");
Console.WriteLine(suv);
Console.WriteLine();

// Build a simple car with minimal options
var carBuilder3 = serviceProvider.GetRequiredService<ICarBuilder>();

Car basicCar = carBuilder3
    .SetSeats(4)
    .Build();  // Uses default engine and transmission

Console.WriteLine("Basic Car (with defaults):");
Console.WriteLine(basicCar);
