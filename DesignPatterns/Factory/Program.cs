using Factory.Dependencies;
using Factory.Enums;
using Factory.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

// Simple Factory Pattern (also known as Static Factory)
// Purpose: Encapsulates object creation logic in a single class
// Use case: When you need to create different types of objects based on a parameter
// Note: This is NOT the Factory Method pattern - that uses inheritance and subclasses

var serviceProvider = FactoryConfiguration.ConfigureServices();

var notificationFactory = serviceProvider.GetRequiredService<INotificationServiceFactory>();

Console.WriteLine("=== Simple Factory Pattern Demo ===\n");

// Use the factory to create notifications based on enum type
// Using enums provides compile-time type safety and better IDE support
var emailNotification = notificationFactory.CreateNotificationService(NotificationType.Email);
emailNotification.Send("This is an email notification!");

Console.WriteLine();

var smsNotification = notificationFactory.CreateNotificationService(NotificationType.Sms);
smsNotification.Send("This is an SMS notification!");

Console.WriteLine();

var pushNotification = notificationFactory.CreateNotificationService(NotificationType.Push);
pushNotification.Send("This is a push notification!");

Console.WriteLine();

// Example: Creating notifications based on runtime configuration
Console.WriteLine("--- Dynamic notification creation from configuration ---");
var notificationTypes = new[] { NotificationType.Email, NotificationType.Sms, NotificationType.Push };

foreach (var type in notificationTypes)
{
    var notification = notificationFactory.CreateNotificationService(type);
    notification.Send($"Notification sent via {type}");
    Console.WriteLine();
}