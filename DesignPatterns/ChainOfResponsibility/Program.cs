using ChainOfResponsibility.Dependencies;
using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models;
using Microsoft.Extensions.DependencyInjection;

// Chain of Responsibility Pattern
// Purpose: Passes requests along a chain of handlers until one handles it
// Use case: Logging, authentication/authorization pipelines, event handling
// Benefits: Decouples sender from receiver, dynamic chain configuration

var serviceProvider = ChainOfResponsibilityConfiguration.ConfigureServices();

Console.WriteLine("=== Chain of Responsibility Pattern Demo ===");
Console.WriteLine("Request processing pipeline\n");

// Build the chain: Validation -> Authentication -> Role -> Authorization -> Logging
var validation = serviceProvider.GetRequiredService<ValidationHandler>();
var authentication = serviceProvider.GetRequiredService<AuthenticationHandler>();
var role = serviceProvider.GetRequiredService<RoleHandler>();
var authorization = serviceProvider.GetRequiredService<AuthorizationHandler>();
var logging = serviceProvider.GetRequiredService<LoggingHandler>();

validation.Next = authentication;
authentication.Next = role;
role.Next = authorization;
authorization.Next = logging;

// Scenario 1: Valid admin request
Console.WriteLine("--- Scenario 1: Admin accessing admin resource ---");
var request1 = new Request
{
    UserName = "admin",
    Password = "admin123",
    Resource = "admin"
};
validation.Handle(request1);
Console.WriteLine($"Result: Authenticated={request1.IsAuthenticated}, Authorized={request1.IsAuthorized}\n");

// Scenario 2: Valid user trying to access admin resource
Console.WriteLine("--- Scenario 2: User trying to access admin resource ---");
var request2 = new Request
{
    UserName = "user",
    Password = "user123",
    Resource = "admin"
};
validation.Handle(request2);
Console.WriteLine($"Result: Authenticated={request2.IsAuthenticated}, Authorized={request2.IsAuthorized}\n");

// Scenario 3: Guest with read access
Console.WriteLine("--- Scenario 3: Guest accessing read resource ---");
var request3 = new Request
{
    UserName = "guest",
    Password = "guest123",
    Resource = "read"
};
validation.Handle(request3);
Console.WriteLine($"Result: Authenticated={request3.IsAuthenticated}, Authorized={request3.IsAuthorized}\n");

// Scenario 4: Invalid credentials
Console.WriteLine("--- Scenario 4: Invalid credentials ---");
var request4 = new Request
{
    UserName = "hacker",
    Password = "wrongpass",
    Resource = "admin"
};
validation.Handle(request4);
Console.WriteLine($"Result: Authenticated={request4.IsAuthenticated}, Authorized={request4.IsAuthorized}\n");

// Scenario 5: Missing username (validation failure)
Console.WriteLine("--- Scenario 5: Missing username ---");
var request5 = new Request
{
    UserName = "",
    Password = "password",
    Resource = "read"
};
validation.Handle(request5);
Console.WriteLine($"Result: Authenticated={request5.IsAuthenticated}, Authorized={request5.IsAuthorized}\n");