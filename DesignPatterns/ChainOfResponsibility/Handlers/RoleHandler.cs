using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    // Concrete Handler: Determines user role
    public class RoleHandler : BaseHandler
    {
        private readonly Dictionary<string, string> _userRoles = new()
        {
            { "admin", "Admin" },
            { "user", "User" },
            { "guest", "Guest" }
        };

        public override void Handle(Request request)
        {
            Console.WriteLine("[RoleHandler] Assigning user role...");

            if (_userRoles.TryGetValue(request.UserName, out var role))
            {
                request.Role = role;
                Console.WriteLine($"[RoleHandler] Role '{role}' assigned to '{request.UserName}'");
                PassToNext(request);
            }
            else
            {
                Console.WriteLine($"[RoleHandler] Could not determine role for '{request.UserName}'");
            }
        }
    }
}
