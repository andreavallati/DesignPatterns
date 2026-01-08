using Factory.Notifications.Interfaces;

namespace Factory.Factories.Interfaces
{
    public interface INotificationServiceFactory
    {
        INotificationService CreateNotificationService(string notificationType);
    }
}
