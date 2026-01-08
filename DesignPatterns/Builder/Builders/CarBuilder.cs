using Builder.Builders.Interfaces;
using Builder.Models;

namespace Builder.Builders
{
    // Builder Pattern: Concrete Builder
    // Provides methods to configure the product step by step
    // Allows constructing complex objects with many optional parameters
    public class CarBuilder : ICarBuilder
    {
        private string? _engine;
        private int _seats;
        private bool _hasGPS;
        private string? _transmission;

        public ICarBuilder SetEngine(string type)
        {
            _engine = $"{type} Engine";
            return this;
        }

        public ICarBuilder SetSeats(int seats)
        {
            _seats = seats;
            return this;
        }

        public ICarBuilder SetGPS()
        {
            _hasGPS = true;
            return this;
        }

        public ICarBuilder SetTransmission(string transmission)
        {
            _transmission = transmission;
            return this;
        }

        public Car Build()
        {
            var car = new Car(
                _engine ?? "Standard", 
                _seats, 
                _hasGPS, 
                _transmission ?? "Manual"
            );
            
            // Reset the builder state after building
            Reset();
            
            return car;
        }

        private void Reset()
        {
            _engine = null;
            _seats = 0;
            _hasGPS = false;
            _transmission = null;
        }
    }
}
