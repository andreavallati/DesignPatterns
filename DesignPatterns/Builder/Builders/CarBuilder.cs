using Builder.Builders.Interfaces;
using Builder.Models;
using Builder.Services.Interfaces;

namespace Builder.Builders
{
    public class CarBuilder : ICarBuilder
    {
        private readonly IEngineBuilderService _engineBuilderService;
        private readonly IGPSService _gpsService;

        private string? _engine;
        private int _seats;
        private bool _hasGPS;
        private string? _transmission;

        public CarBuilder(IEngineBuilderService engineBuilderService, IGPSService gpsService)
        {
            _engineBuilderService = engineBuilderService;
            _gpsService = gpsService;
        }

        public ICarBuilder SetEngine(string type)
        {
            _engine = _engineBuilderService.BuildEngine(type);
            return this;
        }

        public ICarBuilder SetSeats(int seats)
        {
            _seats = seats;
            return this;
        }

        public ICarBuilder SetGPS()
        {
            _hasGPS = _gpsService.InstallGPS();
            return this;
        }

        public ICarBuilder SetTransmission(string transmission)
        {
            _transmission = transmission;
            return this;
        }

        public Car Build()
        {
            var car = new Car(_engine ?? "Standard", _seats, _hasGPS, _transmission ?? "Manual");
            
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
