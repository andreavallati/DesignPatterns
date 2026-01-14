using Mediator.Mediators.Interfaces;

namespace Mediator.Mediators
{
    // Concrete Mediator: Manages communication between users
    public class ChatRoomMediator : IChatRoomMediator
    {
        private readonly List<IUser> _users = new();

        public void RegisterUser(IUser user)
        {
            _users.Add(user);
            Console.WriteLine($"[ChatRoom] {user.Name} joined the chat room");
        }

        public void SendMessage(string message, IUser sender)
        {
            Console.WriteLine($"[ChatRoom] Broadcasting message from {sender.Name}");
            
            foreach (var user in _users)
            {
                // Don't send the message back to the sender
                if (user != sender)
                {
                    user.ReceiveMessage(message, sender.Name);
                }
            }
        }

        public void SendPrivateMessage(string message, IUser sender, string recipientName)
        {
            var recipient = _users.FirstOrDefault(u => u.Name == recipientName);
            
            if (recipient != null)
            {
                Console.WriteLine($"[ChatRoom] Private message from {sender.Name} to {recipientName}");
                recipient.ReceivePrivateMessage(message, sender.Name);
            }
            else
            {
                Console.WriteLine($"[ChatRoom] User '{recipientName}' not found");
            }
        }
    }
}
