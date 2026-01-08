using Factory.Enums;
using Factory.Factories.Interfaces;
using Factory.Notifications;
using Factory.Notifications.Interfaces;

namespace Factory.Factories
{
    // This is a Simple Factory (also known as Static Factory)
    // It encapsulates object creation logic but doesn't use inheritance
    // Note: This is different from the Factory Method pattern which uses inheritance
    public class NotificationServiceFactory : INotificationServiceFactory
    {
        public INotificationService CreateNotificationService(NotificationType notificationType)
        {
            return notificationType switch
            {
                NotificationType.Email => new EmailNotification(),
                NotificationType.Sms => new SmsNotification(),
                NotificationType.Push => new PushNotification(),
                _ => throw new ArgumentException($"Unknown notification type: {notificationType}")
            };
        }
    }
}
