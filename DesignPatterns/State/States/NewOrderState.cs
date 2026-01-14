using State.Models;
using State.States.Interfaces;

namespace State.States
{
    // Concrete State: New Order State
    public class NewOrderState : IOrderState
    {
        private readonly Order _order;

        public NewOrderState(Order order)
        {
            _order = order ?? throw new ArgumentNullException(nameof(order));
        }

        public string GetStateName() => "New";

        public void ProcessOrder()
        {
            Console.WriteLine("Order is being processed...");
            _order.SetState(new ProcessingOrderState(_order));
        }

        public void ShipOrder()
        {
            Console.WriteLine("Cannot ship - Order must be processed first");
        }

        public void DeliverOrder()
        {
            Console.WriteLine("Cannot deliver - Order must be processed and shipped first");
        }

        public void CancelOrder()
        {
            Console.WriteLine("Order cancelled");
            _order.SetState(new CancelledOrderState(_order));
        }
    }
}
