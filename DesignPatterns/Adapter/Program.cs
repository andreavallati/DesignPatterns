using Adapter.Dependencies;
using Adapter.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = AdapterConfiguration.ConfigureServices();

// Retrieve the ILogger instance (which is LoggerAdapter)
var logger = serviceProvider.GetRequiredService<ILogger>();

// Use the logger
logger.Log("This is a log message via Adapter with DI!");

// Expected Output:
// [LegacyLogger] This is a log message via Adapter with DI!
