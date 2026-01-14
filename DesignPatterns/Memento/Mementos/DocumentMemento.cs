namespace Memento.Mementos
{
    // Memento: Stores the internal state of the Originator
    // Immutable to prevent external modification
    public class DocumentMemento
    {
        public string Content { get; }
        public DateTime Timestamp { get; }
        public string Version { get; }

        public DocumentMemento(string content, string version)
        {
            Content = content ?? string.Empty;
            Version = version ?? throw new ArgumentNullException(nameof(version));
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Version {Version} ({Timestamp:yyyy-MM-dd HH:mm:ss}) - Length: {Content.Length} chars";
        }
    }
}
