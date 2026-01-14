using Factory.Enums;
using Factory.Notifications.Interfaces;

namespace Factory.Factories.Interfaces
{
    public interface INotificationServiceFactory
    {
        INotificationService CreateNotificationService(NotificationType notificationType);
    }
}
