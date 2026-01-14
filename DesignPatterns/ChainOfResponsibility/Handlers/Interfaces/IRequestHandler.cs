using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers.Interfaces
{
    // Handler interface for the chain
    public interface IRequestHandler
    {
        IRequestHandler? Next { get; set; }
        void Handle(Request request);
    }
}
