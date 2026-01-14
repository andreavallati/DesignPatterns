using ChainOfResponsibility.Handlers.Interfaces;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    // Abstract base handler with common chain logic
    public abstract class BaseHandler : IRequestHandler
    {
        public IRequestHandler? Next { get; set; }

        public virtual void Handle(Request request)
        {
            // If there's a next handler in the chain, pass the request to it
            Next?.Handle(request);
        }

        protected void PassToNext(Request request)
        {
            if (Next != null)
            {
                Next.Handle(request);
            }
            else
            {
                Console.WriteLine("[Chain] End of chain reached");
            }
        }
    }
}
