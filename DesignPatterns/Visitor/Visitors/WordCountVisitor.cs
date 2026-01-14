using Visitor.Elements;
using Visitor.Visitors.Interfaces;

namespace Visitor.Visitors
{
    // Concrete Visitor: Counts word statistics
    public class WordCountVisitor : IDocumentVisitor
    {
        private int _totalWords;
        private int _totalLinks;
        private int _totalImages;

        public void Visit(Paragraph paragraph)
        {
            _totalWords += CountWords(paragraph.Text);
        }

        public void Visit(Heading heading)
        {
            _totalWords += CountWords(heading.Text);
        }

        public void Visit(Image image)
        {
            _totalImages++;
        }

        public void Visit(HyperLink hyperLink)
        {
            _totalLinks++;
            _totalWords += CountWords(hyperLink.Text);
        }

        private int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }

            return text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public void DisplayStatistics()
        {
            Console.WriteLine("\n--- Document Statistics ---");
            Console.WriteLine($"Total Words: {_totalWords}");
            Console.WriteLine($"Total Links: {_totalLinks}");
            Console.WriteLine($"Total Images: {_totalImages}");
            Console.WriteLine("--- End of Statistics ---\n");
        }
    }
}
