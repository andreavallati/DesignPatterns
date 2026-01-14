using Builder.Models;

namespace Builder.Builders.Interfaces
{
    public interface ICarBuilder
    {
        ICarBuilder SetEngine(string engine);
        ICarBuilder SetSeats(int seats);
        ICarBuilder SetGPS();
        ICarBuilder SetTransmission(string transmission);
        Car Build();
    }
}
