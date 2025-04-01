using Factory.Notifications.Interfaces;

namespace Factory.Factories.Interfaces
{
    public interface INotificationServiceFactory
    {
        TNotificationService CreateNotificationService<TNotificationService>() where TNotificationService : INotificationService;
    }
}
