using Bridge.Implementors.Interfaces;

namespace Bridge.Implementors
{
    // Concrete Implementor: Radio
    public class Radio : IDevice
    {
        private bool _isEnabled;
        private int _volume = 20;
        private int _channel = 1;

        public bool IsEnabled => _isEnabled;

        public void Enable()
        {
            _isEnabled = true;
            Console.WriteLine("[Radio] Turned on");
        }

        public void Disable()
        {
            _isEnabled = false;
            Console.WriteLine("[Radio] Turned off");
        }

        public int GetVolume() => _volume;

        public void SetVolume(int volume)
        {
            _volume = Math.Clamp(volume, 0, 100);
            Console.WriteLine($"[Radio] Volume set to {_volume}%");
        }

        public int GetChannel() => _channel;

        public void SetChannel(int channel)
        {
            _channel = channel;
            Console.WriteLine($"[Radio] Station set to {_channel} FM");
        }
    }
}
