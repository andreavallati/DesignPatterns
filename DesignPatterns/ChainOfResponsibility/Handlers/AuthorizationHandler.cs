using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    // Concrete Handler: Authorizes access to resources
    public class AuthorizationHandler : BaseHandler
    {
        private readonly Dictionary<string, List<string>> _permissions = new()
        {
            { "Admin", new List<string> { "read", "write", "delete", "admin" } },
            { "User", new List<string> { "read", "write" } },
            { "Guest", new List<string> { "read" } }
        };

        public override void Handle(Request request)
        {
            Console.WriteLine("[AuthorizationHandler] Checking permissions...");

            if (_permissions.TryGetValue(request.Role, out var permissions) &&
                permissions.Contains(request.Resource.ToLower()))
            {
                request.IsAuthorized = true;
                Console.WriteLine($"[AuthorizationHandler] User authorized to access '{request.Resource}'");
                PassToNext(request);
            }
            else
            {
                Console.WriteLine($"[AuthorizationHandler] User '{request.UserName}' (Role: {request.Role}) not authorized for '{request.Resource}'");
            }
        }
    }
}
