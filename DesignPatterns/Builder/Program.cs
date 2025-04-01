using Adapter.Dependencies;
using Builder.Builders.Interfaces;
using Builder.Models;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = BuilderConfiguration.ConfigureServices();

var carBuilder = serviceProvider.GetRequiredService<ICarBuilder>();

// Build a car using the injected services
Car sportsCar = carBuilder.SetEngine("V8")
                          .SetSeats(2)
                          .SetGPS()
                          .SetTransmission("Automatic")
                          .Build();

Console.WriteLine(sportsCar);

// Build another car
Car suv = carBuilder.SetEngine("V6")
                    .SetSeats(7)
                    .SetGPS()
                    .SetTransmission("Manual")
                    .Build();

Console.WriteLine(suv);