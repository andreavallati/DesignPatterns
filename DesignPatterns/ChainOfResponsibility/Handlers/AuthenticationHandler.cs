using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    // Concrete Handler: Authenticates user credentials
    public class AuthenticationHandler : BaseHandler
    {
        private readonly Dictionary<string, string> _users = new()
        {
            { "admin", "admin123" },
            { "user", "user123" },
            { "guest", "guest123" }
        };

        public override void Handle(Request request)
        {
            Console.WriteLine("[AuthenticationHandler] Authenticating user...");

            if (_users.TryGetValue(request.UserName, out var password) &&
                password == request.Password)
            {
                request.IsAuthenticated = true;
                Console.WriteLine($"[AuthenticationHandler] User '{request.UserName}' authenticated");
                PassToNext(request);
            }
            else
            {
                Console.WriteLine($"[AuthenticationHandler] Authentication failed for user '{request.UserName}'");
                // Stop the chain
            }
        }
    }
}
