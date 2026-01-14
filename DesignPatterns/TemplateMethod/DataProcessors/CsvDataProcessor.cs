namespace TemplateMethod.DataProcessors
{
    // Concrete Class: CSV Data Processor
    // Implements the specific steps for processing CSV data
    public class CsvDataProcessor : DataProcessor
    {
        protected override void ReadData()
        {
            Console.WriteLine("[CSV] Reading data from CSV file");
        }

        protected override void ProcessDataInternal()
        {
            Console.WriteLine("[CSV] Parsing CSV rows and columns");
            Console.WriteLine("[CSV] Converting data types");
        }

        protected override void TransformData()
        {
            Console.WriteLine("[CSV] Transforming CSV data to objects");
        }

        protected override void SaveData()
        {
            Console.WriteLine("[CSV] Saving processed data to database");
        }

        // Override hook method to customize behavior
        protected override void ValidateData()
        {
            Console.WriteLine("[CSV] Validating CSV format and data integrity");
        }
    }
}
