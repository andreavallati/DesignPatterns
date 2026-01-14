namespace Facade.Subsystems
{
    public class SoundSystem
    {
        public void On()
        {
            Console.WriteLine("[Sound System] Turning on");
        }

        public void Off()
        {
            Console.WriteLine("[Sound System] Turning off");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"[Sound System] Setting volume to {level}");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("[Sound System] Setting surround sound mode");
        }
    }
}
