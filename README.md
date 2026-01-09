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

### Behavioral Patterns
Patterns that deal with object collaboration and responsibility distribution.

| Pattern | Description | Use Case |
|---------|-------------|----------|
| [**Strategy**](#strategy) | Defines family of algorithms, makes them interchangeable | Tax calculations, sorting algorithms, payment methods |
| [**Observer**](#observer) | Defines one-to-many dependency between objects | Event handling, pub/sub systems, data binding |

---

## Pattern Details

### Singleton

**Purpose:** Ensures a class has only one instance and provides global access to it.

**Implementation Highlights:**
- Thread-safe using `Lazy<T>`
- Sealed class prevents inheritance
- Private constructor prevents external instantiation

**Example:**
```csharp
var instance1 = SingletonService.Instance;
var instance2 = SingletonService.Instance;
// instance1 and instance2 are the same object
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

## Best Practices

### When to Use Each Pattern

**Creational Patterns:**
- Use **Singleton** for truly global, single-instance services
- Use **Factory/Factory Method** when object creation logic is complex
- Use **Abstract Factory** for creating families of related objects
- Use **Builder** for objects with many optional parameters
- Use **Prototype** when object creation is expensive

**Structural Patterns:**
- Use **Adapter** to integrate incompatible interfaces
- Use **Decorator** to add responsibilities dynamically

**Behavioral Patterns:**
- Use **Strategy** to make algorithms interchangeable
- Use **Observer** for event-driven architectures

### Modern .NET Considerations

While these patterns are valuable, modern .NET provides alternatives:

- **Singleton:** Consider DI container's singleton lifetime instead
- **Factory:** Consider DI container's factory pattern (`IServiceProvider`)
- **Observer:** Consider `IObservable<T>` / `IObserver<T>` or events

This repository shows **both traditional patterns and modern integration**.

---

### Patterns to Add
- Command
- Chain of Responsibility
- Mediator
- State
- Template Method
- Visitor
- Memento
- Interpreter
- Bridge
- Composite
- Facade
- Flyweight
- Proxy

---
  
## Technologies Used
- .NET Core

---

## Project Structure
```
DesignPatterns/
│── Prototype/
│── Singleton/
│── Strategy/
│── AbstractFactory/
│── Adapter/
│── Builder/
│── Decorator/
│── Factory/
│── FactoryMethod/
│── Observer/
│── DesignPatterns.sln
```

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
