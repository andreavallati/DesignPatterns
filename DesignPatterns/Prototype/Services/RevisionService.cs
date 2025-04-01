using Prototype.Services.Interfaces;

namespace Prototype.Services
{
    public class RevisionService : IRevisionService
    {
        public void TrackChange(string changeDescription)
        {
            Console.WriteLine($"[Revision] {changeDescription}");
        }
    }
}
