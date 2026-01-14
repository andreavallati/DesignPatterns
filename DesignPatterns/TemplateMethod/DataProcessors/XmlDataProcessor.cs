namespace TemplateMethod.DataProcessors
{
    // Concrete Class: XML Data Processor
    // Implements the specific steps for processing XML data
    // Demonstrates disabling validation via hook method
    public class XmlDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("[XML] Reading data from XML file");
        }

        protected override void ProcessDataInternal()
        {
            Console.WriteLine("[XML] Parsing XML nodes and attributes");
            Console.WriteLine("[XML] Loading XML document structure");
        }

        protected override void TransformData()
        {
            Console.WriteLine("[XML] Transforming XML data to entities");
        }

        protected override void SaveData()
        {
            Console.WriteLine("[XML] Saving processed data to database");
        }

        // Override hook method to skip validation
        protected override bool RequiresValidation()
        {
            return false;
        }
    }
}
