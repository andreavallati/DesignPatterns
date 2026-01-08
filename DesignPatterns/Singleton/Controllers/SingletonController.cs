using Singleton.Services;

namespace Singleton.Controllers
{
    public class SingletonController
    {
        public void Execute()
        {
            Console.WriteLine("Controller is executing a task.");
            SingletonService.Instance.PerformAction();
        }
    }
}
