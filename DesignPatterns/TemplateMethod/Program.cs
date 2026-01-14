using Microsoft.Extensions.DependencyInjection;
using TemplateMethod.DataProcessors;
using TemplateMethod.Dependencies;

// Template Method Pattern
// Purpose: Defines the skeleton of an algorithm, deferring some steps to subclasses
// Use case: When you have an algorithm with invariant parts and variant parts
// Benefits: Code reuse, enforce algorithm structure, control extension points

var serviceProvider = TemplateMethodConfiguration.ConfigureServices();

Console.WriteLine("=== Template Method Pattern Demo ===");
Console.WriteLine("Data processing pipeline with different formats\n");

// Process CSV data
Console.WriteLine("--- Processing CSV Data ---");
var csvProcessor = serviceProvider.GetRequiredService<CsvDataProcessor>();
csvProcessor.ProcessData();

Console.WriteLine("\n--- Processing JSON Data ---");
var jsonProcessor = serviceProvider.GetRequiredService<JsonDataProcessor>();
jsonProcessor.ProcessData();

Console.WriteLine("\n--- Processing XML Data ---");
var xmlProcessor = serviceProvider.GetRequiredService<XmlDataProcessor>();
xmlProcessor.ProcessData();