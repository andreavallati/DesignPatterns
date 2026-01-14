using Memento.Mementos;

namespace Memento.Originators
{
    // Originator: The object whose state needs to be saved and restored
    public class Document
    {
        private string _content = string.Empty;
        private int _versionNumber = 0;

        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                _versionNumber++;
            }
        }

        public void Write(string text)
        {
            _content += text;
            _versionNumber++;
            Console.WriteLine($"[Document] Text written: \"{text}\"");
            Console.WriteLine($"[Document] Current content: \"{_content}\"");
        }

        public void Clear()
        {
            _content = string.Empty;
            _versionNumber++;
            Console.WriteLine("[Document] Content cleared");
        }

        // Create a memento containing the current state
        public DocumentMemento CreateMemento()
        {
            Console.WriteLine($"[Document] Creating memento for version {_versionNumber}");
            return new DocumentMemento(_content, $"v{_versionNumber}");
        }

        // Restore state from a memento
        public void RestoreFromMemento(DocumentMemento memento)
        {
            _content = memento.Content;
            Console.WriteLine($"[Document] Restored from {memento.Version} ({memento.Timestamp:HH:mm:ss})");
            Console.WriteLine($"[Document] Content: \"{_content}\"");
        }

        public void Display()
        {
            Console.WriteLine($"\n--- Current Document (Version {_versionNumber}) ---");
            Console.WriteLine($"\"{_content}\"");
            Console.WriteLine($"--- End of Document ---\n");
        }
    }
}
