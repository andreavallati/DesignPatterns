using Composite.Components.Interfaces;

namespace Composite.Components
{
    // Leaf: Represents individual objects (files)
    // Cannot have children
    public class File : IFileSystemComponent
    {
        public string Name { get; }
        private readonly long _size;

        public File(string name, long size)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            _size = size;
        }

        public long GetSize() => _size;

        public void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth * 2)} - {Name} ({FormatSize(_size)})");
        }

        private static string FormatSize(long bytes)
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
    }
}
