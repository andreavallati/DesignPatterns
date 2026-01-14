using Bridge.Implementors.Interfaces;

namespace Bridge.Implementors
{
    // Concrete Implementor: TV
    public class TV : IDevice
    {
        private bool _isEnabled;
        private int _volume = 30;
        private int _channel = 1;

        public bool IsEnabled => _isEnabled;

        public void Enable()
        {
            _isEnabled = true;
            Console.WriteLine("[TV] Turned on");
        }

        public void Disable()
        {
            _isEnabled = false;
            Console.WriteLine("[TV] Turned off");
        }

        public int GetVolume() => _volume;

        public void SetVolume(int volume)
        {
            _volume = Math.Clamp(volume, 0, 100);
            Console.WriteLine($"[TV] Volume set to {_volume}%");
        }

        public int GetChannel() => _channel;

        public void SetChannel(int channel)
        {
            _channel = channel;
            Console.WriteLine($"[TV] Channel set to {_channel}");
        }
    }
}
