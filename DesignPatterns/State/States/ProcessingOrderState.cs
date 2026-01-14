using State.Models;
using State.States.Interfaces;

namespace State.States
{
    // Concrete State: Processing Order State
    public class ProcessingOrderState : IOrderState
    {
        private readonly Order _order;

        public ProcessingOrderState(Order order)
        {
            _order = order ?? throw new ArgumentNullException(nameof(order));
        }

        public string GetStateName() => "Processing";

        public void ProcessOrder()
        {
            Console.WriteLine("Order is already being processed");
        }

        public void ShipOrder()
        {
            Console.WriteLine("Order is being shipped...");
            _order.SetState(new ShippedOrderState(_order));
        }

        public void DeliverOrder()
        {
            Console.WriteLine("Cannot deliver - Order must be shipped first");
        }

        public void CancelOrder()
        {
            Console.WriteLine("Order cancelled during processing");
            _order.SetState(new CancelledOrderState(_order));
        }
    }
}
