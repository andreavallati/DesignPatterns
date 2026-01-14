namespace Visitor.Visitors.Interfaces
{
    // Visitor interface declares visit methods for each element type
    public interface IDocumentVisitor
    {
        void Visit(Elements.Paragraph paragraph);
        void Visit(Elements.Heading heading);
        void Visit(Elements.Image image);
        void Visit(Elements.HyperLink hyperLink);
    }
}
