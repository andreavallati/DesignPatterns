using Bridge.Implementors.Interfaces;

namespace Bridge.Abstractions
{
    // Refined Abstraction: Extends the abstraction with additional features
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            Console.WriteLine("[Advanced Remote] Mute");
            Device.SetVolume(0);
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"[Advanced Remote] Set channel to {channel}");
            Device.SetChannel(channel);
        }

        public void DisplayStatus()
        {
            Console.WriteLine("\n[Advanced Remote] --- Device Status ---");
            Console.WriteLine($"Power: {(Device.IsEnabled ? "ON" : "OFF")}");
            Console.WriteLine($"Volume: {Device.GetVolume()}%");
            Console.WriteLine($"Channel: {Device.GetChannel()}");
            Console.WriteLine("--- End of Status ---\n");
        }
    }
}
