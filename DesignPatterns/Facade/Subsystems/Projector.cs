namespace Facade.Subsystems
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("[Projector] Turning on");
        }

        public void Off()
        {
            Console.WriteLine("[Projector] Turning off");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("[Projector] Setting widescreen mode (16:9)");
        }
    }
}
