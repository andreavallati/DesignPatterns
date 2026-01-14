using Singleton.Services.Interfaces;

namespace Singleton.Controllers
{
    public class SingletonController
    {
        private readonly ISingletonService _singletonService;

        public SingletonController(ISingletonService singletonService)
        {
            _singletonService = singletonService;
        }

        public void Execute()
        {
            Console.WriteLine("Controller is executing a task.");
            _singletonService.PerformAction();
        }
    }
}
