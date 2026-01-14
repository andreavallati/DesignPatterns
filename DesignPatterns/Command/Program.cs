using Command.Commands;
using Command.Dependencies;
using Command.Invokers.Interfaces;
using Command.Models;
using Microsoft.Extensions.DependencyInjection;

// Command Pattern
// Purpose: Encapsulates a request as an object, allowing parameterization and queuing
// Use case: Undo/redo operations, transaction systems, macro recording
// Benefits: Decouples sender from receiver, supports undo/redo, command queuing

var serviceProvider = CommandConfiguration.ConfigureServices();

var editor = serviceProvider.GetRequiredService<ITextEditor>();
var document = serviceProvider.GetRequiredService<TextDocument>();

Console.WriteLine("=== Command Pattern Demo ===");
Console.WriteLine("Text Editor with Undo/Redo functionality\n");

// Execute commands
Console.WriteLine("--- Executing Commands ---\n");

var command1 = new InsertTextCommand(document, "Hello ");
editor.ExecuteCommand(command1);

var command2 = new InsertTextCommand(document, "World");
editor.ExecuteCommand(command2);

var command3 = new InsertTextCommand(document, "!");
editor.ExecuteCommand(command3);

document.Display();

// Undo operations
Console.WriteLine("--- Undo Operations ---\n");

editor.Undo();
document.Display();

editor.Undo();
document.Display();

// Redo operations
Console.WriteLine("--- Redo Operations ---\n");

editor.Redo();
document.Display();

editor.Redo();
document.Display();

// More operations
Console.WriteLine("--- More Operations ---\n");

var command4 = new DeleteTextCommand(document, 6);
editor.ExecuteCommand(command4);
document.Display();

editor.Undo();
document.Display();