using AbstractFactory.Dependencies;
using AbstractFactory.Factories;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = AbstractFactoryConfiguration.ConfigureServices();

// Get Windows factory and create Windows UI components
var windowsFactory = serviceProvider.GetRequiredService<WindowsFactory>();
var windowsButton = windowsFactory.CreateButton();
var windowsCheckBox = windowsFactory.CreateCheckBox();

windowsButton.Paint();
windowsCheckBox.Paint();

Console.WriteLine();

// Get Mac factory and create Mac UI components
var macFactory = serviceProvider.GetRequiredService<MacFactory>();
var macButton = macFactory.CreateButton();
var macCheckBox = macFactory.CreateCheckBox();

macButton.Paint();
macCheckBox.Paint();
