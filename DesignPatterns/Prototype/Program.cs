using Microsoft.Extensions.DependencyInjection;
using Prototype.Dependencies;
using Prototype.Models;
using Prototype.Services.Interfaces;

var serviceProvider = PrototypeConfiguration.ConfigureServices();

var revisionService = serviceProvider.GetRequiredService<IRevisionService>();

// Create an original Document
var originalDocument = new Document(revisionService)
{
    Title = "Design Patterns",
    Content = "The Prototype Pattern...",
    Metadata = new Metadata { Author = "John Doe" }
};

// Clone the Document
var clonedDocument = originalDocument.Clone();
clonedDocument.Title = "Cloned Document";
clonedDocument.AddContent("Additional content in the cloned document.");

// Display the original and cloned document
Console.WriteLine("Original Document:");
Console.WriteLine(originalDocument);
Console.WriteLine("\nCloned Document:");
Console.WriteLine(clonedDocument);
