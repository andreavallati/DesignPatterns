namespace TemplateMethod.DataProcessors
{
    // Concrete Class: JSON Data Processor
    // Implements the specific steps for processing JSON data
    public class JsonDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("[JSON] Reading data from JSON file");
        }

        protected override void ProcessDataInternal()
        {
            Console.WriteLine("[JSON] Parsing JSON structure");
            Console.WriteLine("[JSON] Deserializing JSON objects");
        }

        protected override void TransformData()
        {
            Console.WriteLine("[JSON] Transforming JSON data to domain objects");
        }

        protected override void SaveData()
        {
            Console.WriteLine("[JSON] Saving processed data to database");
        }

        // Override hook method to customize behavior
        protected override void ValidateData()
        {
            Console.WriteLine("[JSON] Validating JSON schema and structure");
        }
    }
}
