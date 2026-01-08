using Factory.Factories.Interfaces;
using Factory.Notifications;
using Factory.Notifications.Interfaces;

namespace Factory.Factories
{
    public class NotificationServiceFactory : INotificationServiceFactory
    {
        public INotificationService CreateNotificationService(string notificationType)
        {
            return notificationType.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms" => new SmsNotification(),
                "push" => new PushNotification(),
                _ => throw new ArgumentException($"Unknown notification type: {notificationType}")
            };
        }
    }
}
