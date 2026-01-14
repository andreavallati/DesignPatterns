using Microsoft.Extensions.DependencyInjection;
using Visitor.Dependencies;
using Visitor.Elements;
using Visitor.Elements.Interfaces;
using Visitor.Visitors;

// Visitor Pattern
// Purpose: Defines new operations on elements without changing element classes
// Use case: Compilers, document processing, syntax tree operations
// Benefits: Easy to add new operations, separates algorithm from object structure

var serviceProvider = VisitorConfiguration.ConfigureServices();

Console.WriteLine("=== Visitor Pattern Demo ===");
Console.WriteLine("Document processing with different export formats\n");

// Create a document with various elements
List<IDocumentElement> document = new()
{
    new Heading("Design Patterns in C#", 1),
    new Paragraph("This document demonstrates the Visitor pattern."),
    new Heading("Introduction", 2),
    new Paragraph("The Visitor pattern allows you to add new operations to existing object structures without modifying those structures."),
    new Image("https://example.com/diagram.png", "Design Pattern Diagram"),
    new Heading("Benefits", 2),
    new Paragraph("It helps you follow the Open/Closed Principle."),
    new HyperLink("https://refactoring.guru/design-patterns/visitor", "Learn more about Visitor pattern"),
    new Paragraph("This is a powerful pattern for working with complex object structures.")
};

Console.WriteLine("--- Document Created ---");
Console.WriteLine($"Total elements: {document.Count}\n");

// Visitor 1: Export to HTML
Console.WriteLine("--- Exporting to HTML ---\n");
var htmlVisitor = serviceProvider.GetRequiredService<HtmlExportVisitor>();
foreach (var element in document)
{
    element.Accept(htmlVisitor);
}
Console.WriteLine(htmlVisitor.GetHtml());

// Visitor 2: Export to Markdown
Console.WriteLine("\n--- Exporting to Markdown ---\n");
var markdownVisitor = serviceProvider.GetRequiredService<MarkdownExportVisitor>();
foreach (var element in document)
{
    element.Accept(markdownVisitor);
}
Console.WriteLine(markdownVisitor.GetMarkdown());

// Visitor 3: Count statistics
Console.WriteLine("--- Analyzing Document Statistics ---");
var statsVisitor = serviceProvider.GetRequiredService<WordCountVisitor>();
foreach (var element in document)
{
    element.Accept(statsVisitor);
}
statsVisitor.DisplayStatistics();
