using Command.Commands.Interfaces;

namespace Command.Invokers.Interfaces
{
    public interface ITextEditor
    {
        void ExecuteCommand(ICommand command);
        void Undo();
        void Redo();
        bool CanUndo { get; }
        bool CanRedo { get; }
    }
}
