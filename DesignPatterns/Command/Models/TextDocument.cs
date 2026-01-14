namespace Command.Models
{
    // Receiver: The object that performs the actual work
    public class TextDocument
    {
        private string _content = string.Empty;

        public string Content => _content;

        public void InsertText(string text)
        {
            _content += text;
            Console.WriteLine($"Text inserted: '{text}'");
            Console.WriteLine($"Current content: '{_content}'");
        }

        public void DeleteText(int length)
        {
            if (length > _content.Length)
            {
                length = _content.Length;
            }

            var deletedText = _content.Substring(_content.Length - length);
            _content = _content.Substring(0, _content.Length - length);

            Console.WriteLine($"Text deleted: '{deletedText}'");
            Console.WriteLine($"Current content: '{_content}'");
        }

        public void Clear()
        {
            _content = string.Empty;
            Console.WriteLine("Document cleared");
        }

        public void Display()
        {
            Console.WriteLine($"\n--- Document Content ---");
            Console.WriteLine($"'{_content}'");
            Console.WriteLine($"--- End of Document ---\n");
        }
    }
}
