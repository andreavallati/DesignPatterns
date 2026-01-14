# Design Patterns in C#

## Overview

A comprehensive collection of **Gang of Four (GoF) Design Patterns** implemented in modern C# with .NET 8, demonstrating best practices, SOLID principles, and dependency injection.

This repository provides **production-ready, educational implementations** of classic design patterns. Each pattern is:

- Implemented as a separate .NET 8 console project
- Fully integrated with **Dependency Injection (DI)**
- Documented with clear comments explaining the pattern's purpose
- Demonstrated with practical, real-world examples

---

## Design Patterns Implemented

### Creational Patterns
Patterns that deal with object creation mechanisms.

| Pattern | Description | Use Case |
|---------|-------------|----------|
| [**Singleton**](#singleton) | Ensures a class has only one instance | Configuration managers, logging, caching |
| [**Factory** (Simple Factory)](#factory) | Encapsulates object creation logic | Creating objects based on type parameters |
| [**Factory Method**](#factory-method) | Defines interface for creating objects, subclasses decide types | Frameworks that need to delegate instantiation |
| [**Abstract Factory**](#abstract-factory) | Creates families of related objects | Cross-platform UI components, theme systems |
| [**Builder**](#builder) | Constructs complex objects step-by-step | Building objects with many optional parameters |
| [**Prototype**](#prototype) | Creates new objects by cloning existing ones | When object creation is expensive |

### Structural Patterns
Patterns that deal with object composition and relationships.

| Pattern | Description | Use Case |
|---------|-------------|----------|
| [**Adapter**](#adapter) | Makes incompatible interfaces work together | Integrating legacy code, third-party libraries |
| [**Decorator**](#decorator) | Adds behavior to objects dynamically | Adding features without modifying classes |
| [**Facade**](#facade) | Provides simplified interface to complex subsystem | Simplifying complex APIs, library wrappers |
| [**Proxy**](#proxy) | Provides placeholder for another object | Lazy loading, access control, remote objects |
| [**Bridge**](#bridge) | Separates abstraction from implementation | Cross-platform apps, device drivers |
| [**Composite**](#composite) | Composes objects into tree structures | File systems, UI hierarchies, organization charts |

### Behavioral Patterns
Patterns that deal with object collaboration and responsibility distribution.

| Pattern | Description | Use Case |
|---------|-------------|----------|
| [**Strategy**](#strategy) | Defines family of algorithms, makes them interchangeable | Tax calculations, sorting algorithms, payment methods |
| [**Observer**](#observer) | Defines one-to-many dependency between objects | Event handling, pub/sub systems, data binding |
| [**Command**](#command) | Encapsulates requests as objects | Undo/redo, transaction systems, macro recording |
| [**Template Method**](#template-method) | Defines algorithm skeleton, subclasses implement steps | Data processing pipelines, frameworks |
| [**State**](#state) | Changes behavior when internal state changes | State machines, workflow systems, order processing |
| [**Chain of Responsibility**](#chain-of-responsibility) | Passes requests along a chain of handlers | Logging, authentication pipelines, event bubbling |
| [**Mediator**](#mediator) | Centralizes complex communications between objects | Chat systems, UI dialogs, air traffic control |
| [**Memento**](#memento) | Captures and restores object state | Undo/redo, snapshots, save points |
| [**Visitor**](#visitor) | Defines new operations without changing element classes | Compilers, document processing, reporting |

---

## Pattern Details

### Singleton

**Purpose:** Ensures a class has only one instance and provides global access to it.

**Modern Implementation (DI-Managed):**
- Lifetime managed by DI container
- No static dependencies (better testability)
- Thread-safe by default
- Follows Dependency Inversion Principle

**Example:**

```csharp
// Registration in DI container
services.AddSingleton<ISingletonService, SingletonService>();

// Usage via constructor injection
public class MyController
{
    private readonly ISingletonService _singletonService;
    
    public MyController(ISingletonService singletonService)
    {
        _singletonService = singletonService;
    }
}
```

**Run:**
```bash
dotnet run --project Singleton
```

---

### Factory

**Purpose:** Encapsulates object creation logic in a single class (Simple Factory pattern).

**Implementation Highlights:**
- Centralized creation logic
- Enum-based type selection for type safety
- Clear separation from Factory Method pattern

**Example:**
```csharp
var emailNotification = factory.CreateNotificationService(NotificationType.Email);
emailNotification.Send("Hello!");
```

**Run:**
```bash
dotnet run --project Factory
```

---

### Factory Method

**Purpose:** Defines an interface for creating objects, but lets subclasses decide which class to instantiate.

**Implementation Highlights:**
- Abstract creator with template method
- Subclasses override factory method
- Parent class contains business logic

**Example:**
```csharp
DocumentCreator pdfCreator = new PdfDocumentCreator();
pdfCreator.ProcessDocument(); // Creates and processes PDF document
```

**Run:**
```bash
dotnet run --project FactoryMethod
```

---

### Abstract Factory

**Purpose:** Provides an interface for creating families of related objects without specifying concrete classes.

**Implementation Highlights:**
- Multiple product families (Windows/Mac UI)
- Client code works with abstract interfaces
- Easy platform switching

**Example:**
```csharp
IGUIFactory factory = new WindowsFactory();
var button = factory.CreateButton();
var checkbox = factory.CreateCheckBox();
```

**Run:**
```bash
dotnet run --project AbstractFactory
```

---

### Builder

**Purpose:** Separates the construction of a complex object from its representation.

**Implementation Highlights:**
- Fluent interface with method chaining
- Handles optional parameters elegantly
- Builder state resets after building

**Example:**
```csharp
Car sportsCar = carBuilder
    .SetEngine("V8")
    .SetSeats(2)
    .SetGPS()
    .SetTransmission("Automatic")
    .Build();
```

**Run:**
```bash
dotnet run --project Builder
```

---

### Prototype

**Purpose:** Creates new objects by cloning existing ones.

**Implementation Highlights:**
- Deep cloning support
- Integrated with dependency injection
- Generic `IPrototype<T>` interface

**Example:**
```csharp
var originalDocument = new Document { Title = "Design Patterns" };
var clonedDocument = originalDocument.Clone();
clonedDocument.Title = "Cloned Document";
```

**Run:**
```bash
dotnet run --project Prototype
```

---

### Adapter

**Purpose:** Allows incompatible interfaces to work together.

**Implementation Highlights:**
- Wraps legacy system with modern interface
- Maintains existing functionality
- Enables DI integration

**Example:**
```csharp
ILogger logger = new LoggerAdapter(new LegacyLogger());
logger.Log("Message"); // Uses legacy system internally
```

**Run:**
```bash
dotnet run --project Adapter
```

---

### Decorator

**Purpose:** Adds behavior to objects dynamically without modifying their structure.

**Implementation Highlights:**
- Wraps objects with additional functionality
- Maintains same interface
- Composable decorators

**Example:**
```csharp
ICoffee coffee = new SimpleCoffee();
coffee = new MilkDecorator(coffee);
coffee = new SugarDecorator(coffee);
// Coffee with milk and sugar
```

**Run:**
```bash
dotnet run --project Decorator
```

---

### Strategy

**Purpose:** Defines a family of algorithms and makes them interchangeable.

**Implementation Highlights:**
- Runtime algorithm selection
- Encapsulates each algorithm
- Context delegates to strategy

**Example:**
```csharp
taxCalculator.SetStrategy(new UsaTaxStrategy());
decimal tax = taxCalculator.CalculateTax(1000);

taxCalculator.SetStrategy(new CanadaTaxStrategy());
decimal canadaTax = taxCalculator.CalculateTax(1000);
```

**Run:**
```bash
dotnet run --project Strategy
```

---

### Observer

**Purpose:** Defines a one-to-many dependency between objects.

**Implementation Highlights:**
- Push-based notification model
- Multiple observers with different behaviors
- Dynamic registration/removal

**Example:**
```csharp
weatherStation.RegisterObserver(temperatureDisplay);
weatherStation.RegisterObserver(statisticsDisplay);
weatherStation.SetWeatherData(25.5f, 65.0f, 1013.1f);
// All observers get notified
```

**Run:**
```bash
dotnet run --project Observer
```
---

### Facade

**Purpose:** Provides a simplified interface to a complex subsystem of classes.

**Implementation Highlights:**
- Unified interface to multiple subsystem components
- Reduces client-subsystem coupling
- Simplifies complex operations into single methods

**Example:**

```csharp
// Without facade: many method calls on multiple objects
dvdPlayer.On();
projector.On();
projector.WideScreenMode();
soundSystem.On();
soundSystem.SetVolume(5);
// ...many more calls

// With facade: one simple call
homeTheater.WatchMovie("Inception");
```

**Run:**

```sh
dotnet run --project Facade
```

---

### Command

**Purpose:** Encapsulates a request as an object, allowing parameterization and queuing of requests.

**Implementation Highlights:**
- Commands as first-class objects
- Undo/redo functionality through command history
- Invoker decoupled from receiver
- Commands can be queued, logged, or stored

**Example:**

```csharp
var insertCommand = new InsertTextCommand(document, "Hello");
editor.ExecuteCommand(insertCommand);

editor.Undo(); // Reverses the insert
editor.Redo(); // Re-applies the insert
```

**Run:**

```sh
dotnet run --project Command
```

---

### Template Method

**Purpose:** Defines the skeleton of an algorithm, deferring some steps to subclasses.

**Implementation Highlights:**
- Algorithm structure defined in base class
- Abstract methods for required overrides
- Hook methods for optional customization
- Prevents code duplication

**Example:**

```csharp
// Base class defines the algorithm
public abstract class DataProcessor
{
    public void ProcessData() // Template method
    {
        ReadData();          // Abstract - must override
        ProcessInternal();   // Abstract - must override
        if (RequiresValidation()) // Hook - optional override
            ValidateData();
        SaveData();          // Abstract - must override
    }
}
```

**Run:**

```sh
dotnet run --project TemplateMethod
```

---

### State

**Purpose:** Allows an object to alter its behavior when its internal state changes.

**Implementation Highlights:**
- Each state encapsulates its own behavior
- State transitions are explicit
- Eliminates complex conditional logic
- Easy to add new states

**Example:**

```csharp
var order = new Order(new NewOrderState(order));

order.ProcessOrder(); // New -> Processing
order.ShipOrder();    // Processing -> Shipped
order.DeliverOrder(); // Shipped -> Delivered
```

**Run:**

```sh
dotnet run --project State
```

---

### Proxy

**Purpose:** Provides a surrogate or placeholder for another object to control access to it.

**Types Demonstrated:**
- **Virtual Proxy:** Lazy loading of expensive objects
- **Protection Proxy:** Access control based on permissions

**Implementation Highlights:**
- Same interface as real object
- Controls access to the real object
- Can add caching, logging, or security

**Example:**

```csharp
// Virtual proxy - delays loading until needed
IImage image = new ImageProxy("large-photo.jpg");
image.Display(); // Loads and displays on first access
image.Display(); // Uses cached version

// Protection proxy - access control
IImage protectedImage = new ProtectedImageProxy("secret.jpg", "Guest");
protectedImage.Display(); // Access denied
```

**Run:**

```sh
dotnet run --project Proxy
```

---

### Composite

**Purpose:** Composes objects into tree structures to represent part-whole hierarchies.

**Implementation Highlights:**
- Uniform interface for leaf and composite objects
- Recursive composition enables complex hierarchies
- Clients treat individual objects and compositions uniformly

**Example:**

```csharp
// Create file system structure
var root = new Directory("root");
var documents = new Directory("Documents");
documents.Add(new File("resume.pdf", 512 * 1024));

root.Add(documents);
root.Display(); // Shows entire hierarchy
Console.WriteLine($"Total size: {root.GetSize()}"); // Aggregates sizes
```

**Run:**

```sh
dotnet run --project Composite
```

---

### Bridge

**Purpose:** Separates abstraction from implementation so both can vary independently.

**Implementation Highlights:**
- Decouples interface from implementation
- Both hierarchies can evolve separately
- Composition over inheritance

**Example:**

```csharp
// Same remote type works with different devices
IDevice tv = new TV();
IDevice radio = new Radio();

RemoteControl remoteForTV = new RemoteControl(tv);
RemoteControl remoteForRadio = new RemoteControl(radio);

// Can add new devices or remotes independently
```

**Run:**

```sh
dotnet run --project Bridge
```

---

### Chain of Responsibility

**Purpose:** Passes requests along a chain of handlers until one handles it.

**Implementation Highlights:**
- Dynamic chain configuration
- Each handler decides to process or pass the request
- Decouples sender from receiver

**Example:**

```csharp
// Build processing pipeline
validation.Next = authentication;
authentication.Next = role;
role.Next = authorization;

// Request flows through the chain
validation.Handle(request);
```

**Run:**

```sh
dotnet run --project ChainOfResponsibility
```

---

### Mediator

**Purpose:** Defines an object that encapsulates how a set of objects interact.

**Implementation Highlights:**
- Centralizes complex communications
- Reduces coupling between components
- Colleagues only know about the mediator

**Example:**

```csharp
var chatRoom = new ChatRoomMediator();
var alice = new User("Alice", chatRoom);
var bob = new User("Bob", chatRoom);

chatRoom.RegisterUser(alice);
chatRoom.RegisterUser(bob);

alice.SendMessage("Hello everyone!"); // Broadcast
alice.SendPrivateMessage("Hi Bob", "Bob"); // Private
```

**Run:**

```sh
dotnet run --project Mediator
```

---

### Memento

**Purpose:** Captures and externalizes an object's internal state for later restoration.

**Implementation Highlights:**
- Preserves encapsulation boundaries
- Supports undo/redo functionality
- Caretaker manages memento lifecycle

**Example:**

```csharp
var document = new Document();
var history = new DocumentHistory();

document.Write("Hello");
history.Save(document.CreateMemento());

document.Write(" World");
history.Save(document.CreateMemento());

// Undo
var memento = history.Undo();
document.RestoreFromMemento(memento);
```

**Run:**

```sh
dotnet run --project Memento
```

---

### Visitor

**Purpose:** Defines new operations on elements without changing element classes.

**Implementation Highlights:**
- Separates algorithm from object structure
- Easy to add new operations
- Double dispatch mechanism

**Example:**

```csharp
List<IDocumentElement> document = new()
{
    new Heading("Title", 1),
    new Paragraph("Content"),
    new Image("url", "alt")
};

// Apply different operations via visitors
var htmlVisitor = new HtmlExportVisitor();
var markdownVisitor = new MarkdownExportVisitor();

foreach (var element in document)
{
    element.Accept(htmlVisitor);
    element.Accept(markdownVisitor);
}
```

**Run:**

```sh
dotnet run --project Visitor
```

---

## Project Structure

Each pattern follows a consistent structure:

```
PatternName/
├── Dependencies/           # DI configuration
│   └── PatternConfiguration.cs
├── Models/                # Domain models (if needed)
├── Services/              # Business logic
│   └── Interfaces/        # Service abstractions
├── Program.cs             # Entry point with examples
└── PatternName.csproj     # Project file
```

---

## Best Practices

### When to Use Each Pattern

**Creational Patterns:**
- Use **Singleton** for truly global, single-instance services (prefer DI container management)
- Use **Factory/Factory Method** when object creation logic is complex
- Use **Abstract Factory** for creating families of related objects
- Use **Builder** for objects with many optional parameters
- Use **Prototype** when object creation is expensive

**Structural Patterns:**
- Use **Adapter** to integrate incompatible interfaces
- Use **Decorator** to add responsibilities dynamically
- Use **Facade** to simplify complex subsystem interactions
- Use **Proxy** for lazy loading, access control, or remote object access
- Use **Bridge** when both abstraction and implementation should vary independently
- Use **Composite** for tree structures and part-whole hierarchies

**Behavioral Patterns:**
- Use **Strategy** to make algorithms interchangeable
- Use **Observer** for event-driven architectures
- Use **Command** for undo/redo, transactions, or operation queuing
- Use **Template Method** when you have invariant algorithm structure with variant steps
- Use **State** for state machines and complex state-dependent behavior
- Use **Chain of Responsibility** for processing pipelines and request handling
- Use **Mediator** to reduce coupling between communicating objects
- Use **Memento** for undo/redo and state snapshots
- Use **Visitor** when you need many unrelated operations on stable object structures

---
  
## Technologies Used

- **.NET 8** - Latest LTS version
- **C# 12** - Modern language features
- **Microsoft.Extensions.DependencyInjection** - Built-in DI container

---

## Installation
### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- Any IDE that supports C# (Visual Studio 2022, VS Code, Rider)

### Steps

1. **Clone the repository:**
   ```bash
   git clone https://github.com/andreavallati/DesignPatterns.git
   cd DesignPatterns
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Build the solution:**
   ```bash
   dotnet build
   ```

---

## Resources

### Books
- **"Design Patterns: Elements of Reusable Object-Oriented Software"** - Gang of Four
- **"Head First Design Patterns"** - Freeman & Robson
- **"Refactoring to Patterns"** - Joshua Kerievsky

### Online Resources
- [Refactoring.Guru - Design Patterns](https://refactoring.guru/design-patterns)
- [Microsoft Docs - Design Patterns](https://docs.microsoft.com/en-us/azure/architecture/patterns/)
- [C# Design Patterns](https://www.dofactory.com/net/design-patterns)

---

<div align="center">

**Happy Coding!**

</div>
