using FactoryMethod.Creators;
using FactoryMethod.Dependencies;
using Microsoft.Extensions.DependencyInjection;

// Factory Method Pattern
// Purpose: Define an interface for creating objects, but let subclasses decide which class to instantiate
// Key Point: Subclasses override the factory method to specify the type of object to create
// The parent class contains business logic that relies on the factory method

var serviceProvider = FactoryMethodConfiguration.ConfigureServices();

Console.WriteLine("=== Factory Method Pattern Demo ===\n");
Console.WriteLine("The Factory Method pattern delegates object creation to subclasses.");
Console.WriteLine("Each creator subclass decides which concrete product to instantiate.\n");

// Client code works with creators through their abstract interface
// The creator's business logic (ProcessDocument) is the same for all,
// but each subclass creates a different type of document

Console.WriteLine("--- Processing with PDF Creator ---");
DocumentCreator pdfCreator = serviceProvider.GetRequiredService<PdfDocumentCreator>();
pdfCreator.ProcessDocument();

Console.WriteLine("--- Processing with Word Creator ---");
DocumentCreator wordCreator = serviceProvider.GetRequiredService<WordDocumentCreator>();
wordCreator.ProcessDocument();

Console.WriteLine("--- Processing with Excel Creator ---");
DocumentCreator excelCreator = serviceProvider.GetRequiredService<ExcelDocumentCreator>();
excelCreator.ProcessDocument();

// You can also create documents directly if needed
Console.WriteLine("--- Direct document creation ---");
var pdfDocument = pdfCreator.CreateDocument();
pdfDocument.Open();
