using AbstractFactory.Factories;
using AbstractFactory.Products;
using Microsoft.Extensions.DependencyInjection;
using Singleton.Dependencies;

var serviceProvider = AbstractFactoryConfiguration.ConfigureServices();

var windowsFactory = serviceProvider.GetRequiredService<WindowsFactory>();
windowsFactory.CreateProduct<WindowsButton>().Paint();
windowsFactory.CreateProduct<WindowsCheckBox>().Paint();

var macFactory = serviceProvider.GetRequiredService<MacFactory>();
macFactory.CreateProduct<MacButton>().Paint();
macFactory.CreateProduct<MacCheckBox>().Paint();
