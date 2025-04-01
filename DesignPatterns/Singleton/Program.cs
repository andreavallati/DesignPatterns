using Microsoft.Extensions.DependencyInjection;
using Singleton.Controllers;
using Singleton.Dependencies;

var serviceProvider = SingletonConfiguration.ConfigureServices();

// Get and use the controller
var firstController = serviceProvider.GetRequiredService<SingletonController>();
firstController?.Execute();

// Retrieve another controller instance and see if it shares the Singleton instance
var secondController = serviceProvider.GetService<SingletonController>();
secondController?.Execute();
