using Proxy.Services.Interfaces;

namespace Proxy.Services
{
    // Protection Proxy: Controls access based on permissions
    public class ProtectedImageProxy : IImage
    {
        private readonly string _fileName;
        private readonly string _userRole;
        private RealImage? _realImage;

        public ProtectedImageProxy(string fileName, string userRole)
        {
            _fileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
            _userRole = userRole ?? throw new ArgumentNullException(nameof(userRole));
            Console.WriteLine($"[ProtectedProxy] Created for '{_fileName}' with user role: {_userRole}");
        }

        public string GetFileName() => _fileName;

        public void Display()
        {
            // Check permissions before allowing access
            if (!HasAccess())
            {
                Console.WriteLine($"[ProtectedProxy] Access denied for role '{_userRole}'");
                return;
            }

            Console.WriteLine($"[ProtectedProxy] Access granted for role '{_userRole}'");

            // Lazy loading
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }

            _realImage.Display();
        }

        private bool HasAccess()
        {
            // Simple access control: only admins and users can view images
            return _userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
                   _userRole.Equals("User", StringComparison.OrdinalIgnoreCase);
        }
    }
}
