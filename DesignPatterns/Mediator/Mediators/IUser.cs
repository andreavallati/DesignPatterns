using Mediator.Mediators.Interfaces;

namespace Mediator.Mediators
{
    // Colleague interface
    public interface IUser
    {
        string Name { get; }
        void ReceiveMessage(string message, string senderName);
        void ReceivePrivateMessage(string message, string senderName);
    }
}
