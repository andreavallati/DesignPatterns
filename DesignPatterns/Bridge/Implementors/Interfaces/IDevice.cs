namespace Bridge.Implementors.Interfaces
{
    // Implementor: Defines interface for implementation classes
    public interface IDevice
    {
        bool IsEnabled { get; }
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int volume);
        int GetChannel();
        void SetChannel(int channel);
    }
}
