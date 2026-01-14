using TemplateMethod.DataProcessors.Interfaces;

namespace TemplateMethod.DataProcessors
{
    // Template Method Pattern: Abstract Class
    // Defines the skeleton of an algorithm in a method (the template method)
    // Subclasses override specific steps without changing the algorithm's structure
    public abstract class DataProcessor : IDataProcessor
    {
        // Template Method: Defines the algorithm structure
        // This method should NOT be overridden by subclasses
        public void ProcessData()
        {
            ReadData();
            ProcessDataInternal();
            
            if (RequiresValidation())
            {
                ValidateData();
            }
            
            TransformData();
            SaveData();
        }

        // Abstract methods: Must be implemented by subclasses
        protected abstract void ReadData();
        protected abstract void ProcessDataInternal();
        protected abstract void TransformData();
        protected abstract void SaveData();

        // Hook method: Optional override point with default behavior
        // Subclasses can override this to change behavior
        protected virtual bool RequiresValidation()
        {
            return true;
        }

        // Hook method: Provides default implementation
        protected virtual void ValidateData()
        {
            Console.WriteLine("[Base] Performing default validation");
        }
    }
}
