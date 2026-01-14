using Visitor.Elements.Interfaces;
using Visitor.Visitors.Interfaces;

namespace Visitor.Elements
{
    // Concrete Element: Image
    public class Image : IDocumentElement
    {
        public string Url { get; set; }
        public string AltText { get; set; }

        public Image(string url, string altText)
        {
            Url = url ?? throw new ArgumentNullException(nameof(url));
            AltText = altText ?? throw new ArgumentNullException(nameof(altText));
        }

        public void Accept(IDocumentVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
