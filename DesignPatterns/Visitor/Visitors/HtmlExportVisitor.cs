using Visitor.Elements;
using Visitor.Visitors.Interfaces;

namespace Visitor.Visitors
{
    // Concrete Visitor: Exports to HTML
    public class HtmlExportVisitor : IDocumentVisitor
    {
        private readonly List<string> _html = new();

        public void Visit(Paragraph paragraph)
        {
            _html.Add($"<p>{paragraph.Text}</p>");
        }

        public void Visit(Heading heading)
        {
            _html.Add($"<h{heading.Level}>{heading.Text}</h{heading.Level}>");
        }

        public void Visit(Image image)
        {
            _html.Add($"<img src=\"{image.Url}\" alt=\"{image.AltText}\" />");
        }

        public void Visit(HyperLink hyperLink)
        {
            _html.Add($"<a href=\"{hyperLink.Url}\">{hyperLink.Text}</a>");
        }

        public string GetHtml()
        {
            return string.Join("\n", _html);
        }
    }
}
