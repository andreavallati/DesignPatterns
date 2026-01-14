using Command.Commands.Interfaces;
using Command.Invokers.Interfaces;

namespace Command.Invokers
{
    // Invoker: Stores and executes commands
    // Maintains history for undo/redo functionality
    public class TextEditor : ITextEditor
    {
        private readonly Stack<ICommand> _undoStack = new();
        private readonly Stack<ICommand> _redoStack = new();

        public bool CanUndo => _undoStack.Count > 0;
        public bool CanRedo => _redoStack.Count > 0;

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _undoStack.Push(command);
            _redoStack.Clear(); // Clear redo stack when new command is executed
        }

        public void Undo()
        {
            if (!CanUndo)
            {
                Console.WriteLine("Nothing to undo");
                return;
            }

            var command = _undoStack.Pop();
            command.Undo();
            _redoStack.Push(command);
        }

        public void Redo()
        {
            if (!CanRedo)
            {
                Console.WriteLine("Nothing to redo");
                return;
            }

            var command = _redoStack.Pop();
            command.Execute();
            _undoStack.Push(command);
        }
    }
}
