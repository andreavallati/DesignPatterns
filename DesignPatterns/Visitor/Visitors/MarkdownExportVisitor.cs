using Visitor.Elements;
using Visitor.Visitors.Interfaces;

namespace Visitor.Visitors
{
    // Concrete Visitor: Exports to Markdown
    public class MarkdownExportVisitor : IDocumentVisitor
    {
        private readonly List<string> _markdown = new();

        public void Visit(Paragraph paragraph)
        {
            _markdown.Add($"{paragraph.Text}\n");
        }

        public void Visit(Heading heading)
        {
            var prefix = new string('#', heading.Level);
            _markdown.Add($"{prefix} {heading.Text}\n");
        }

        public void Visit(Image image)
        {
            _markdown.Add($"[{image.AltText}]({image.Url})\n");
        }

        public void Visit(HyperLink hyperLink)
        {
            _markdown.Add($"[{hyperLink.Text}]({hyperLink.Url})");
        }

        public string GetMarkdown()
        {
            return string.Join("", _markdown);
        }
    }
}
