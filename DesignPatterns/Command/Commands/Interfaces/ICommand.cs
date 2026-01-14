namespace Command.Commands.Interfaces
{
    // Command Pattern: Command Interface
    // Declares an interface for executing operations
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
