using FactoryMethod.Creators;
using FactoryMethod.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Singleton.Dependencies;

var serviceProvider = FactoryMethodConfiguration.ConfigureServices();

var documentFactory = serviceProvider.GetRequiredService<IDocumentFactory>();

// Create and open different documents by specifying the creator type
var pdfDocument = documentFactory.CreateDocument<PdfDocumentCreator>();
pdfDocument.Open();  // Output: Opening a PDF document.

var wordDocument = documentFactory.CreateDocument<WordDocumentCreator>();
wordDocument.Open();  // Output: Opening a Word document.

var excelDocument = documentFactory.CreateDocument<ExcelDocumentCreator>();
excelDocument.Open();  // Output: Opening an Excel document.