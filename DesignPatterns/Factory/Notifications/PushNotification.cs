using Factory.Notifications.Interfaces;

namespace Factory.Notifications
{
    public class PushNotification : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Push Notification: " + message);
        }
    }
}
