using Visitor.Elements.Interfaces;
using Visitor.Visitors.Interfaces;

namespace Visitor.Elements
{
    // Concrete Element: Heading
    public class Heading : IDocumentElement
    {
        public string Text { get; set; }
        public int Level { get; set; }

        public Heading(string text, int level)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
            Level = level;
        }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
