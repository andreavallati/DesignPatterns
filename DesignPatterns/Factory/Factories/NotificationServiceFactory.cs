using Factory.Factories.Interfaces;
using Factory.Notifications.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Factory.Factories
{
    public class NotificationServiceFactory : INotificationServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public NotificationServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        public TNotificationService CreateNotificationService<TNotificationService>() where TNotificationService : INotificationService
        {
            var notificationService = _serviceProvider.GetRequiredService<TNotificationService>();

            if (notificationService is null)
            {
                throw new InvalidOperationException("Notification service not found.");
            }

            return notificationService;
        }
    }
}
