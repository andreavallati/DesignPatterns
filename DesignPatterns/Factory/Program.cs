using Factory.Dependencies;
using Factory.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = FactoryConfiguration.ConfigureServices();

var notificationFactory = serviceProvider.GetRequiredService<INotificationServiceFactory>();

// Use the factory to create notifications based on string type
var emailNotification = notificationFactory.CreateNotificationService("email");
emailNotification.Send("This is an email notification!");

var smsNotification = notificationFactory.CreateNotificationService("sms");
smsNotification.Send("This is an SMS notification!");

var pushNotification = notificationFactory.CreateNotificationService("push");
pushNotification.Send("This is a push notification!");