using Composite.Components.Interfaces;

namespace Composite.Components
{
    // Composite: Represents containers that can hold other components (directories)
    // Can have children (both files and other directories)
    public class Directory : IFileSystemComponent
    {
        public string Name { get; }
        private readonly List<IFileSystemComponent> _children = new();

        public Directory(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        // Methods to manage children
        public void Add(IFileSystemComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IFileSystemComponent component)
        {
            _children.Remove(component);
        }

        public IReadOnlyList<IFileSystemComponent> GetChildren() => _children.AsReadOnly();

        // Composite operation: delegates to children and aggregates results
        public long GetSize()
        {
            return _children.Sum(child => child.GetSize());
        }

        public void Display(int depth = 0)
        {
            Console.WriteLine($"{new string(' ', depth * 2)} - {Name}/ ({FormatSize(GetSize())})");
            foreach (var child in _children)
            {
                child.Display(depth + 1);
            }
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
