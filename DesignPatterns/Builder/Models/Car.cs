namespace Builder.Models
{
    public class Car
    {
        public string Engine { get; private set; }
        public int Seats { get; private set; }
        public bool HasGPS { get; private set; }
        public string Transmission { get; private set; }

        internal Car(string engine, int seats, bool hasGPS, string transmission)
        {
            Engine = engine;
            Seats = seats;
            HasGPS = hasGPS;
            Transmission = transmission;
        }

        public override string ToString()
        {
            return $"Car with Engine: {Engine}, Seats: {Seats}, GPS: {HasGPS}, Transmission: {Transmission}";
        }
    }
}
