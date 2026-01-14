using Memento.Mementos;

namespace Memento.Caretakers
{
    // Caretaker: Manages mementos and provides undo/redo functionality
    // Doesn't examine or modify memento contents
    public class DocumentHistory
    {
        private readonly Stack<DocumentMemento> _history = new();
        private readonly Stack<DocumentMemento> _redoStack = new();

        public void Save(DocumentMemento memento)
        {
            _history.Push(memento);
            _redoStack.Clear(); // Clear redo stack when new save occurs
            Console.WriteLine($"[History] Saved: {memento}");
        }

        public DocumentMemento? Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _redoStack.Push(memento);
                
                if (_history.Count > 0)
                {
                    var previousMemento = _history.Peek();
                    Console.WriteLine($"[History] Undo to: {previousMemento}");
                    return previousMemento;
                }
                else
                {
                    Console.WriteLine("[History] No more history to undo");
                    return new DocumentMemento(string.Empty, "v0"); // Empty state
                }
            }
            
            Console.WriteLine("[History] Nothing to undo");
            return null;
        }

        public DocumentMemento? Redo()
        {
            if (_redoStack.Count > 0)
            {
                var memento = _redoStack.Pop();
                _history.Push(memento);
                Console.WriteLine($"[History] Redo to: {memento}");
                return memento;
            }
            
            Console.WriteLine("[History] Nothing to redo");
            return null;
        }

        public void ShowHistory()
        {
            Console.WriteLine("\n--- Document History ---");
            if (_history.Count == 0)
            {
                Console.WriteLine("(empty)");
            }
            else
            {
                var historyList = _history.ToList();
                historyList.Reverse();
                for (int i = 0; i < historyList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {historyList[i]}");
                }
            }
            Console.WriteLine("--- End of History ---\n");
        }
    }
}
