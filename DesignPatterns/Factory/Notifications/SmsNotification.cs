using Factory.Notifications.Interfaces;

namespace Factory.Notifications
{
    public class SmsNotification : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending Sms Notification: " + message);
        }
    }
}
