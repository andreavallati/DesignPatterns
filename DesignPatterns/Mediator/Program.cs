using Mediator.Colleagues;
using Mediator.Dependencies;
using Mediator.Mediators.Interfaces;
using Microsoft.Extensions.DependencyInjection;

// Mediator Pattern
// Purpose: Defines an object that encapsulates how a set of objects interact
// Use case: Chat rooms, UI dialogs, air traffic control, event systems
// Benefits: Reduces coupling, centralizes communication logic, easy to extend

var serviceProvider = MediatorConfiguration.ConfigureServices();

Console.WriteLine("=== Mediator Pattern Demo ===");
Console.WriteLine("Chat room with centralized communication\n");

// Get the mediator
var chatRoom = serviceProvider.GetRequiredService<IChatRoomMediator>();

// Create users
Console.WriteLine("--- Users Joining Chat Room ---\n");
var alice = new User("Alice", chatRoom);
var bob = new User("Bob", chatRoom);
var charlie = new User("Charlie", chatRoom);
var diana = new User("Diana", chatRoom);

// Register users with the mediator
chatRoom.RegisterUser(alice);
chatRoom.RegisterUser(bob);
chatRoom.RegisterUser(charlie);
chatRoom.RegisterUser(diana);

// Scenario 1: Broadcast messages
Console.WriteLine("\n--- Scenario 1: Broadcast Messages ---\n");
alice.SendMessage("Hello everyone!");
Console.WriteLine();

bob.SendMessage("Hi Alice! Welcome to the chat!");
Console.WriteLine();

charlie.SendMessage("Hey folks, great to be here!");
Console.WriteLine();

// Scenario 2: Private messages
Console.WriteLine("\n--- Scenario 2: Private Messages ---\n");
alice.SendPrivateMessage("Bob, can we talk privately?", "Bob");
Console.WriteLine();

bob.SendPrivateMessage("Sure Alice, what's up?", "Alice");
Console.WriteLine();

// Scenario 3: Private message to non-existent user
Console.WriteLine("\n--- Scenario 3: Message to Non-Existent User ---\n");
diana.SendPrivateMessage("Are you there?", "Eve");
Console.WriteLine();

// Scenario 4: Mixed communication
Console.WriteLine("\n--- Scenario 4: Mixed Communication ---\n");
diana.SendMessage("Does anyone know about the Mediator pattern?");
Console.WriteLine();

charlie.SendPrivateMessage("I can explain it to you", "Diana");
Console.WriteLine();

alice.SendMessage("It's great for decoupling objects!");
Console.WriteLine();
