namespace Facade.Subsystems
{
    public class Lights
    {
        public void Dim(int level)
        {
            Console.WriteLine($"[Lights] Dimming to {level}%");
        }

        public void On()
        {
            Console.WriteLine("[Lights] Turning lights on");
        }
    }
}
