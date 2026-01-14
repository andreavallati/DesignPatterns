using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    // Concrete Handler: Logs the request
    public class LoggingHandler : BaseHandler
    {
        public override void Handle(Request request)
        {
            Console.WriteLine("[LoggingHandler] Logging request...");
            Console.WriteLine($"[LoggingHandler] User: {request.UserName}, Resource: {request.Resource}, Authenticated: {request.IsAuthenticated}, Authorized: {request.IsAuthorized}");
            Console.WriteLine("[LoggingHandler] Request logged");
            PassToNext(request);
        }
    }
}
