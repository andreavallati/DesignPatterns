using Proxy.Dependencies;
using Proxy.Services;
using Proxy.Services.Interfaces;

// Proxy Pattern
// Purpose: Provides a surrogate or placeholder for another object to control access to it
// Types: Virtual Proxy (lazy loading), Protection Proxy (access control), Remote Proxy, etc.
// Benefits: Controls access, adds functionality without changing the real object

ProxyConfiguration.ConfigureServices();

Console.WriteLine("=== Proxy Pattern Demo ===\n");

// Scenario 1: Virtual Proxy (Lazy Loading)
Console.WriteLine("--- Scenario 1: Virtual Proxy (Lazy Loading) ---\n");

Console.WriteLine("Creating proxies for images (not loaded yet):");
IImage image1 = new ImageProxy("photo1.jpg");
IImage image2 = new ImageProxy("photo2.jpg");

Console.WriteLine("\nDisplaying image1 for the first time:");
image1.Display();

Console.WriteLine("\nDisplaying image1 again (using cache):");
image1.Display();

Console.WriteLine("\nDisplaying image2 for the first time:");
image2.Display();

// Scenario 2: Protection Proxy (Access Control)
Console.WriteLine("\n\n--- Scenario 2: Protection Proxy (Access Control) ---\n");

Console.WriteLine("Admin user accessing image:");
IImage adminImage = new ProtectedImageProxy("confidential.jpg", "Admin");
adminImage.Display();

Console.WriteLine("\nRegular user accessing image:");
IImage userImage = new ProtectedImageProxy("document.jpg", "User");
userImage.Display();

Console.WriteLine("\nGuest user accessing image:");
IImage guestImage = new ProtectedImageProxy("secret.jpg", "Guest");
guestImage.Display();

// Scenario 3: Direct access (no proxy)
Console.WriteLine("\n\n--- Scenario 3: Direct Access (No Proxy) ---\n");

Console.WriteLine("Creating and displaying real image directly:");
IImage realImage = new RealImage("direct.jpg");
realImage.Display();
