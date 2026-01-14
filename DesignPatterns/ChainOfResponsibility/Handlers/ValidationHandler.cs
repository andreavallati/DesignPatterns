using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    // Concrete Handler: Validates request format
    public class ValidationHandler : BaseHandler
    {
        public override void Handle(Request request)
        {
            Console.WriteLine("[ValidationHandler] Checking request format...");

            if (string.IsNullOrWhiteSpace(request.UserName))
            {
                Console.WriteLine("[ValidationHandler] Validation failed: Username is required");
                return; // Stop the chain
            }

            if (string.IsNullOrWhiteSpace(request.Password))
            {
                Console.WriteLine("[ValidationHandler] Validation failed: Password is required");
                return; // Stop the chain
            }

            Console.WriteLine("[ValidationHandler] Validation passed");
            PassToNext(request);
        }
    }
}
