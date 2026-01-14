using Factory.Notifications.Interfaces;

namespace Factory.Notifications
{
    public class EmailNotification : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Email Notification: " + message);
        }
    }
}
