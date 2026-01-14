using Proxy.Services.Interfaces;

namespace Proxy.Services
{
    // Real Subject: The actual object that does the work
    // Loading the image is an expensive operation
    public class RealImage : IImage
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
            LoadFromDisk();
        }

        public string GetFileName() => _fileName;

        private void LoadFromDisk()
        {
            Console.WriteLine($"[RealImage] Loading '{_fileName}' from disk...");
            // Simulate expensive loading operation
            Thread.Sleep(1000);
            Console.WriteLine($"[RealImage] '{_fileName}' loaded successfully");
        }

        public void Display()
        {
            Console.WriteLine($"[RealImage] Displaying '{_fileName}'");
        }
    }
}
