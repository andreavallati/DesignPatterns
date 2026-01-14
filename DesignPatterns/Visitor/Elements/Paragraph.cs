using Visitor.Elements.Interfaces;
using Visitor.Visitors.Interfaces;

namespace Visitor.Elements
{
    // Concrete Element: Paragraph
    public class Paragraph : IDocumentElement
    {
        public string Text { get; set; }

        public Paragraph(string text)
        {
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
