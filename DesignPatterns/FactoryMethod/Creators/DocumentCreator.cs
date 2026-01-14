using FactoryMethod.Creators.Interfaces;
using FactoryMethod.Products.Interfaces;

namespace FactoryMethod.Creators
{
    // Factory Method Pattern: Abstract Creator
    // Defines the factory method that subclasses override to create specific products
    // The creator may also contain core business logic that relies on the factory method
    public abstract class DocumentCreator : IDocumentCreator
    {
        // Factory Method - subclasses decide which concrete class to instantiate
        public abstract IDocument CreateDocument();

        // Template method that uses the factory method
        // This demonstrates the pattern's power: the algorithm is defined here,
        // but the specific object creation is delegated to subclasses
        public void ProcessDocument()
        {
            Console.WriteLine("Starting document processing workflow...");
            
            // Use the factory method - the actual product type is determined by the subclass
            var document = CreateDocument();
            
            Console.Write("  ");
            document.Open();
            
            Console.WriteLine("Processing document content...");
            Console.WriteLine("Saving document...");
            Console.WriteLine("Document processing complete.\n");
        }
    }
}
