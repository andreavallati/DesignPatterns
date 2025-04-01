using Factory.Factories.Interfaces;
using Factory.Notifications;
using Microsoft.Extensions.DependencyInjection;
using Singleton.Dependencies;

var serviceProvider = FactoryConfiguration.ConfigureServices();

var notificationFactory = serviceProvider.GetRequiredService<INotificationServiceFactory>();

// Use the factory to create notifications
var emailNotification = notificationFactory.CreateNotificationService<EmailNotification>();
emailNotification.Send("This is an email notification!");

var smsNotification = notificationFactory.CreateNotificationService<SmsNotification>();
smsNotification.Send("This is an SMS notification!");

var pushNotification = notificationFactory.CreateNotificationService<PushNotification>();
pushNotification.Send("This is a push notification!");