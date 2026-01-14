using Visitor.Visitors.Interfaces;

namespace Visitor.Elements.Interfaces
{
    // Element interface with Accept method
    public interface IDocumentElement
    {
        void Accept(IDocumentVisitor visitor);
    }
}
