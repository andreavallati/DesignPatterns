namespace Mediator.Mediators.Interfaces
{
    public interface IChatRoomMediator
    {
        void RegisterUser(IUser user);
        void SendMessage(string message, IUser sender);
        void SendPrivateMessage(string message, IUser sender, string recipientName);
    }
}
