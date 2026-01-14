using Memento.Caretakers;
using Memento.Dependencies;
using Memento.Originators;
using Microsoft.Extensions.DependencyInjection;

// Memento Pattern
// Purpose: Captures and externalizes an object's internal state for later restoration
// Use case: Undo/redo, snapshots, transaction rollback, save points
// Benefits: Preserves encapsulation, simplifies originator, history management

var serviceProvider = MementoConfiguration.ConfigureServices();

var document = serviceProvider.GetRequiredService<Document>();
var history = serviceProvider.GetRequiredService<DocumentHistory>();

Console.WriteLine("=== Memento Pattern Demo ===");
Console.WriteLine("Document editing with undo/redo functionality\n");

// Initial state
Console.WriteLine("--- Creating Document ---\n");
history.Save(document.CreateMemento());

// Edit 1
Console.WriteLine("\n--- Edit 1: Writing content ---\n");
document.Write("Hello, ");
history.Save(document.CreateMemento());
document.Display();

// Edit 2
Console.WriteLine("--- Edit 2: Adding more content ---\n");
document.Write("World!");
history.Save(document.CreateMemento());
document.Display();

// Edit 3
Console.WriteLine("--- Edit 3: Adding signature ---\n");
document.Write(" - John Doe");
history.Save(document.CreateMemento());
document.Display();

// Show history
history.ShowHistory();

// Undo operations
Console.WriteLine("--- Undo 1 ---\n");
var memento = history.Undo();
if (memento != null)
{
    document.RestoreFromMemento(memento);
    document.Display();
}

Console.WriteLine("--- Undo 2 ---\n");
memento = history.Undo();
if (memento != null)
{
    document.RestoreFromMemento(memento);
    document.Display();
}

// Redo operations
Console.WriteLine("--- Redo 1 ---\n");
memento = history.Redo();
if (memento != null)
{
    document.RestoreFromMemento(memento);
    document.Display();
}

// New edit after undo (clears redo stack)
Console.WriteLine("--- New Edit: Modifying content ---\n");
document.Write(" Goodbye!");
history.Save(document.CreateMemento());
document.Display();

Console.WriteLine("--- Attempting Redo (should fail) ---\n");
history.Redo();

// Final history
history.ShowHistory();
