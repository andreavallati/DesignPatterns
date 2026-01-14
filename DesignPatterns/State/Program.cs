using State.Dependencies;
using State.Models;
using State.States;

// State Pattern
// Purpose: Allows an object to alter its behavior when its internal state changes
// Use case: State machines, workflow systems, order processing
// Benefits: Eliminates complex conditional logic, makes state transitions explicit

StateConfiguration.ConfigureServices();

Console.WriteLine("=== State Pattern Demo ===");
Console.WriteLine("Order processing state machine\n");

// Create order with initial state
// Note: The order needs a reference to itself in the state, so we create it in two steps
var order = new Order(null!);
order.SetState(new NewOrderState(order));

Console.WriteLine("\n--- Scenario 1: Normal Order Flow ---");
order.ProcessOrder();      // New -> Processing
order.ShipOrder();         // Processing -> Shipped
order.DeliverOrder();      // Shipped -> Delivered

Console.WriteLine("\n--- Scenario 2: Attempt Invalid Operations ---");
order.ProcessOrder();      // Invalid: Already delivered
order.CancelOrder();       // Invalid: Already delivered

Console.WriteLine("\n\n--- Scenario 3: Order Cancellation ---");
var order2 = new Order(null!);
order2.SetState(new NewOrderState(order2));

order2.ProcessOrder();     // New -> Processing
order2.CancelOrder();      // Processing -> Cancelled
order2.ShipOrder();        // Invalid: Order cancelled

Console.WriteLine("\n\n--- Scenario 4: Early Cancellation ---");
var order3 = new Order(null!);
order3.SetState(new NewOrderState(order3));

order3.CancelOrder();      // New -> Cancelled (immediate cancellation)
order3.ProcessOrder();     // Invalid: Order cancelled