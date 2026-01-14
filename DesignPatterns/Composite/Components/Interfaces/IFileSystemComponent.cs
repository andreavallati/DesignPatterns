namespace Composite.Components.Interfaces
{
    // Component: Common interface for both leaf and composite objects
    public interface IFileSystemComponent
    {
        string Name { get; }
        long GetSize();
        void Display(int depth = 0);
    }
}
