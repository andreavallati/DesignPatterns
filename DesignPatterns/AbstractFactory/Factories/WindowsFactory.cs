using AbstractFactory.Factories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactory.Factories
{
    public class WindowsFactory : IGUIFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public WindowsFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        public TElement CreateProduct<TElement>() where TElement : class
        {
            var guiElement = _serviceProvider.GetRequiredService<TElement>();

            if (guiElement is null)
            {
                throw new InvalidOperationException("Unknown product type");
            }

            return guiElement;
        }
    }
}
