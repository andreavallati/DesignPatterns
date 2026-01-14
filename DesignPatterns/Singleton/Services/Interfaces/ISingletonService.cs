namespace Singleton.Services.Interfaces
{
    public interface ISingletonService
    {
        void PerformAction();
        Guid GetInstanceId();
    }
}
