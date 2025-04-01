# Design Patterns in C#

## Overview
This project demonstrates various **design patterns** implemented in C#. Each pattern is encapsulated in its own module with a structured approach using **dependency injection**, **interfaces**, and **best coding practices**.

## Features

### 1. Prototype Pattern
**Definition:** The Prototype pattern is a creational design pattern that allows cloning existing objects without being dependent on their specific classes.

**Implementation Details:**
- The `Document` class supports cloning via the `Clone()` method.
- Uses `IRevisionService` to manage revisions.
- Example usage in `Program.cs`:
  ```csharp
  var originalDocument = new Document(revisionService)
  {
      Title = "Design Patterns",
      Content = "The Prototype Pattern...",
      Metadata = new Metadata { Author = "John Doe" }
  };
  
  var clonedDocument = originalDocument.Clone();
  clonedDocument.Title = "Cloned Document";
  clonedDocument.AddContent("Additional content in the cloned document.");
  ```

### 2. Singleton Pattern
**Definition:** The Singleton pattern ensures that a class has only **one instance** and provides a global point of access.

**Implementation Details:**
- Uses `SingletonConfiguration.ConfigureServices()` for DI.
- The `SingletonController` manages the single instance.
- Example usage in `Program.cs`:
  ```csharp
  var firstController = serviceProvider.GetRequiredService<SingletonController>();
  firstController?.Execute();
  
  var secondController = serviceProvider.GetService<SingletonController>();
  secondController?.Execute();
  ```

### 3. Strategy Pattern
**Definition:** Defines a family of algorithms, encapsulates each one, and makes them interchangeable.

**Implementation Details:**
- Uses an interface `IStrategy` for algorithm variations.
- Different implementations (`ConcreteStrategyA`, `ConcreteStrategyB`) are injected dynamically.
- Example usage:
  ```csharp
  IStrategy strategy = new ConcreteStrategyA();
  Context context = new Context(strategy);
  context.ExecuteStrategy();
  ```

### 4. Abstract Factory Pattern
**Definition:** Provides an interface for creating families of related or dependent objects without specifying their concrete classes.

**Implementation Details:**
- Defines `IAbstractFactory` interface with methods to create products.
- Concrete factories (`ConcreteFactoryA`, `ConcreteFactoryB`) implement creation logic.
- Example usage:
  ```csharp
  IAbstractFactory factory = new ConcreteFactoryA();
  var product = factory.CreateProduct();
  product.UseProduct();
  ```

### 5. Adapter Pattern
**Definition:** Converts the interface of a class into another interface that a client expects.

**Implementation Details:**
- Implements `IAdapter` interface to wrap an existing class (`Adaptee`).
- Allows compatibility between incompatible interfaces.
- Example usage:
  ```csharp
  IAdapter adapter = new ConcreteAdapter(new Adaptee());
  adapter.Request();
  ```

### 6. Builder Pattern
**Definition:** Separates object construction from its representation, allowing the same construction process to create different representations.

**Implementation Details:**
- Implements `IBuilder` interface with step-by-step construction methods.
- `Director` class orchestrates object construction.
- Example usage:
  ```csharp
  var builder = new ConcreteBuilder();
  Director director = new Director(builder);
  director.Construct();
  Product product = builder.GetResult();
  ```

### 7. Decorator Pattern
**Definition:** Allows behavior to be added to an individual object, dynamically, without affecting the behavior of other objects from the same class.

**Implementation Details:**
- Uses `IComponent` interface for base functionality.
- `ConcreteDecorator` extends `ConcreteComponent` functionality dynamically.
- Example usage:
  ```csharp
  IComponent component = new ConcreteComponent();
  IComponent decorated = new ConcreteDecorator(component);
  decorated.Operation();
  ```

### 8. Factory Pattern
**Definition:** Provides a way to instantiate objects without specifying their concrete classes.

**Implementation Details:**
- Uses `IFactory` interface to define object creation methods.
- Concrete factories (`ConcreteFactoryA`, `ConcreteFactoryB`) instantiate objects based on input type.
- Example usage:
  ```csharp
  IFactory factory = new ConcreteFactoryA();
  IProduct product = factory.CreateProduct();
  product.Use();
  ```

### 9. Factory Method Pattern
**Definition:** Defines an interface for creating an object but lets subclasses alter the type of objects that will be created.

**Implementation Details:**
- `Creator` class defines an abstract method `CreateProduct()`.
- Concrete implementations override this method to instantiate specific products.
- Example usage:
  ```csharp
  Creator creator = new ConcreteCreator();
  IProduct product = creator.CreateProduct();
  product.Use();
  ```

### 10. Observer Pattern
**Definition:** Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified automatically.

**Implementation Details:**
- Uses `ISubject` interface for managing observers.
- `ConcreteSubject` maintains a list of observers and notifies them on state changes.
- Example usage:
  ```csharp
  ISubject subject = new ConcreteSubject();
  IObserver observer1 = new ConcreteObserver();
  IObserver observer2 = new ConcreteObserver();
  subject.Attach(observer1);
  subject.Attach(observer2);
  subject.Notify();
  ```
  
## Technologies Used
- .NET Core

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

## Installation
### Prerequisites
- .NET SDK 6.0 or later

### Steps
1. Clone the repository:
   ```sh
   git clone <repository-url>
   cd DesignPatterns
   ```
2. Install dependencies:
   ```sh
   dotnet restore
   ```

## Usage
### 1. Run a specific pattern
   ```sh
   dotnet run --project Prototype/Prototype.csproj
   ```
   ```sh
   dotnet run --project Singleton/Singleton.csproj
   ```
   ```sh
   dotnet run --project Strategy/Strategy.csproj
   ```
   ```sh
   dotnet run --project Strategy/Factory.csproj
   ```
