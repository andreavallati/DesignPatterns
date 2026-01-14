using Command.Commands.Interfaces;
using Command.Models;

namespace Command.Commands
{
    // Concrete Command: Encapsulates a request to insert text
    public class InsertTextCommand : ICommand
    {
        private readonly TextDocument _document;
        private readonly string _text;

        public InsertTextCommand(TextDocument document, string text)
        {
            _document = document ?? throw new ArgumentNullException(nameof(document));
            _text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public void Execute()
        {
            _document.InsertText(_text);
        }

        public void Undo()
        {
            _document.DeleteText(_text.Length);
        }
    }
}
