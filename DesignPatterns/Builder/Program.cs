using Builder.Builders.Interfaces;
using Builder.Dependencies;
using Builder.Models;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = BuilderConfiguration.ConfigureServices();

// Get a new builder instance for the first car
var carBuilder1 = serviceProvider.GetRequiredService<ICarBuilder>();

Car sportsCar = carBuilder1.SetEngine("V8")
                           .SetSeats(2)
                           .SetGPS()
                           .SetTransmission("Automatic")
                           .Build();

Console.WriteLine(sportsCar);

// Get a new builder instance for the second car
var carBuilder2 = serviceProvider.GetRequiredService<ICarBuilder>();

Car suv = carBuilder2.SetEngine("V6")
                     .SetSeats(7)
                     .SetGPS()
                     .SetTransmission("Manual")
                     .Build();

Console.WriteLine(suv);