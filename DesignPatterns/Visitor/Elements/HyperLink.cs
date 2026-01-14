using Visitor.Elements.Interfaces;
using Visitor.Visitors.Interfaces;

namespace Visitor.Elements
{
    // Concrete Element: HyperLink
    public class HyperLink : IDocumentElement
    {
        public string Url { get; set; }
        public string Text { get; set; }

        public HyperLink(string url, string text)
        {
            Url = url ?? throw new ArgumentNullException(nameof(url));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
