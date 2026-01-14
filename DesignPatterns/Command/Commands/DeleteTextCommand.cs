using Command.Commands.Interfaces;
using Command.Models;

namespace Command.Commands
{
    // Concrete Command: Encapsulates a request to delete text
    public class DeleteTextCommand : ICommand
    {
        private readonly TextDocument _document;
        private readonly int _length;
        private string _deletedText = string.Empty;

        public DeleteTextCommand(TextDocument document, int length)
        {
            _document = document ?? throw new ArgumentNullException(nameof(document));
            _length = length;
        }

        public void Execute()
        {
            var actualLength = Math.Min(_length, _document.Content.Length);
            _deletedText = _document.Content.Substring(_document.Content.Length - actualLength);
            _document.DeleteText(actualLength);
        }

        public void Undo()
        {
            _document.InsertText(_deletedText);
        }
    }
}
