using Proxy.Services.Interfaces;

namespace Proxy.Services
{
    // Proxy: Controls access to the real subject
    // Implements lazy loading - only loads the real image when needed
    public class ImageProxy : IImage
    {
        private readonly string _fileName;
        private RealImage? _realImage;

        public ImageProxy(string fileName)
        {
            _fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
            Console.WriteLine($"[Proxy] ImageProxy created for '{_fileName}' (not loaded yet)");
        }

        public string GetFileName() => _fileName;

        public void Display()
        {
            // Lazy loading: Only create the real image when it's actually needed
            if (_realImage == null)
            {
                Console.WriteLine($"[Proxy] First access - loading real image...");
                _realImage = new RealImage(_fileName);
            }
            else
            {
                Console.WriteLine($"[Proxy] Using cached image");
            }

            _realImage.Display();
        }
    }
}
