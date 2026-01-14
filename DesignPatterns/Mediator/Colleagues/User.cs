using Mediator.Mediators.Interfaces;

namespace Mediator.Colleagues
{
    // Concrete Colleague: User in the chat room
    public class User : Mediator.Mediators.IUser
    {
        private readonly IChatRoomMediator _mediator;

        public string Name { get; }

        public User(string name, IChatRoomMediator mediator)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"{Name}: Sending message: \"{message}\"");
            _mediator.SendMessage(message, this);
        }

        public void SendPrivateMessage(string message, string recipientName)
        {
            Console.WriteLine($"{Name}: Sending private message to {recipientName}: \"{message}\"");
            _mediator.SendPrivateMessage(message, this, recipientName);
        }

        public void ReceiveMessage(string message, string senderName)
        {
            Console.WriteLine($"- {Name} received from {senderName}: \"{message}\"");
        }

        public void ReceivePrivateMessage(string message, string senderName)
        {
            Console.WriteLine($"- {Name} received PRIVATE from {senderName}: \"{message}\"");
        }
    }
}
