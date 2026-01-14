namespace Prototype.Services.Interfaces
{
    public interface IRevisionService
    {
        void TrackChange(string changeDescription);
    }
}
