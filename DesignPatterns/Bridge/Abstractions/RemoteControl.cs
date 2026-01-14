using Bridge.Implementors.Interfaces;

namespace Bridge.Abstractions
{
    // Abstraction: Defines the high-level control interface
    // Note: Made non-abstract to allow direct instantiation for basic remote
    public class RemoteControl
    {
        protected IDevice Device;

        public RemoteControl(IDevice device)
        {
            Device = device ?? throw new ArgumentNullException(nameof(device));
        }

        public virtual void TogglePower()
        {
            Console.WriteLine("[Remote] Toggle power");
            if (Device.IsEnabled)
            {
                Device.Disable();
            }
            else
            {
                Device.Enable();
            }
        }

        public virtual void VolumeUp()
        {
            Console.WriteLine("[Remote] Volume up");
            Device.SetVolume(Device.GetVolume() + 10);
        }

        public virtual void VolumeDown()
        {
            Console.WriteLine("[Remote] Volume down");
            Device.SetVolume(Device.GetVolume() - 10);
        }

        public virtual void ChannelUp()
        {
            Console.WriteLine("[Remote] Channel up");
            Device.SetChannel(Device.GetChannel() + 1);
        }

        public virtual void ChannelDown()
        {
            Console.WriteLine("[Remote] Channel down");
            Device.SetChannel(Device.GetChannel() - 1);
        }
    }
}
