using AbstractFactory.Dependencies;
using AbstractFactory.Enums;
using AbstractFactory.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

// Abstract Factory Pattern
// Purpose: Provide an interface for creating families of related objects without specifying concrete classes
// Use case: When you need to create objects that belong to different families (e.g., Windows UI vs Mac UI)
// Key Point: Client code works with abstract interfaces, not concrete implementations

var serviceProvider = AbstractFactoryConfiguration.ConfigureServices();

Console.WriteLine("=== Abstract Factory Pattern Demo ===\n");
Console.WriteLine("Creating UI components for different platforms using abstract factories.\n");

// Simulate platform selection using enum (could come from configuration, user input, etc.)
// Using enums provides type safety and prevents typos
PlatformType selectedPlatform = PlatformType.Windows;

// Get the appropriate factory based on platform
// Client code works with IGUIFactory interface, not concrete types
IGUIFactory factory = AbstractFactoryConfiguration.GetFactory(serviceProvider, selectedPlatform);

Console.WriteLine($"--- Creating {selectedPlatform} UI Components ---");
CreateAndRenderUI(factory);

Console.WriteLine();

// Switch to a different platform
selectedPlatform = PlatformType.Mac;
factory = AbstractFactoryConfiguration.GetFactory(serviceProvider, selectedPlatform);

Console.WriteLine($"--- Creating {selectedPlatform} UI Components ---");
CreateAndRenderUI(factory);

Console.WriteLine();

// Example: Creating UI for all available platforms dynamically
Console.WriteLine("--- Creating UI for all platforms ---");
foreach (PlatformType platform in Enum.GetValues<PlatformType>())
{
    Console.WriteLine($"\nPlatform: {platform}");
    var platformFactory = AbstractFactoryConfiguration.GetFactory(serviceProvider, platform);
    CreateAndRenderUI(platformFactory);
}

// This method demonstrates working with the abstract factory
// It has no knowledge of concrete factory or product types
static void CreateAndRenderUI(IGUIFactory factory)
{
    var button = factory.CreateButton();
    var checkbox = factory.CreateCheckBox();

    button.Paint();
    checkbox.Paint();
}

