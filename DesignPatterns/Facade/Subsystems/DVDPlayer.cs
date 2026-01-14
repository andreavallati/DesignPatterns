namespace Facade.Subsystems
{
    public class DVDPlayer
    {
        public void On()
        {
            Console.WriteLine("[DVD Player] Turning on");
        }

        public void Off()
        {
            Console.WriteLine("[DVD Player] Turning off");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"[DVD Player] Playing '{movie}'");
        }

        public void Stop()
        {
            Console.WriteLine("[DVD Player] Stopping playback");
        }

        public void Eject()
        {
            Console.WriteLine("[DVD Player] Ejecting disc");
        }
    }
}
