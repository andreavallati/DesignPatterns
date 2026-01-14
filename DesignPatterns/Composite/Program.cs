using Composite.Components;
using Composite.Dependencies;
using FileComponent = Composite.Components.File;
using DirectoryComponent = Composite.Components.Directory;

// Composite Pattern
// Purpose: Compose objects into tree structures to represent part-whole hierarchies
// Use case: File systems, UI component trees, organization hierarchies
// Benefits: Clients treat individual objects and compositions uniformly

CompositeConfiguration.ConfigureServices();

Console.WriteLine("=== Composite Pattern Demo ===");
Console.WriteLine("File system hierarchy representation\n");

// Create a file system structure
var root = new DirectoryComponent("root");

// Documents folder
var documents = new DirectoryComponent("Documents");
documents.Add(new FileComponent("resume.pdf", 1024 * 512));      // 512 KB
documents.Add(new FileComponent("cover-letter.docx", 1024 * 256)); // 256 KB

// Projects folder
var projects = new DirectoryComponent("Projects");

var designPatterns = new DirectoryComponent("DesignPatterns");
designPatterns.Add(new FileComponent("Composite.cs", 1024 * 8));    // 8 KB
designPatterns.Add(new FileComponent("Strategy.cs", 1024 * 6));     // 6 KB
designPatterns.Add(new FileComponent("Observer.cs", 1024 * 10));    // 10 KB

var webApp = new DirectoryComponent("WebApp");
webApp.Add(new FileComponent("Program.cs", 1024 * 15));             // 15 KB
webApp.Add(new FileComponent("appsettings.json", 1024 * 2));        // 2 KB

projects.Add(designPatterns);
projects.Add(webApp);

// Photos folder
var photos = new DirectoryComponent("Photos");
photos.Add(new FileComponent("vacation.jpg", 1024 * 1024 * 5));     // 5 MB
photos.Add(new FileComponent("family.jpg", 1024 * 1024 * 3));       // 3 MB
photos.Add(new FileComponent("sunset.png", 1024 * 1024 * 7));       // 7 MB

// Add all to root
root.Add(documents);
root.Add(projects);
root.Add(photos);

// Display the entire structure
Console.WriteLine("--- File System Structure ---\n");
root.Display();

// Demonstrate treating leaf and composite uniformly
Console.WriteLine("\n--- Individual Component Sizes ---");
Console.WriteLine($"Documents folder size: {FormatBytes(documents.GetSize())}");
Console.WriteLine($"Projects folder size: {FormatBytes(projects.GetSize())}");
Console.WriteLine($"DesignPatterns subfolder size: {FormatBytes(designPatterns.GetSize())}");
Console.WriteLine($"Total root size: {FormatBytes(root.GetSize())}");

// Demonstrate adding/removing
Console.WriteLine("\n--- Adding New File ---");
var newFile = new FileComponent("notes.txt", 1024 * 5); // 5 KB
documents.Add(newFile);
Console.WriteLine($"Added notes.txt to Documents");
Console.WriteLine($"Documents folder new size: {FormatBytes(documents.GetSize())}");

static string FormatBytes(long bytes)
{
    string[] sizes = { "B", "KB", "MB", "GB" };
    double len = bytes;
    int order = 0;
    while (len >= 1024 && order < sizes.Length - 1)
    {
        order++;
        len /= 1024;
    }
    return $"{len:0.##} {sizes[order]}";
}
