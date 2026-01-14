using State.Models;
using State.States.Interfaces;

namespace State.States
{
    // Concrete State: Cancelled Order State
    public class CancelledOrderState : IOrderState
    {
        private readonly Order _order;

        public CancelledOrderState(Order order)
        {
            _order = order ?? throw new ArgumentNullException(nameof(order));
        }

        public string GetStateName() => "Cancelled";

        public void ProcessOrder()
        {
            Console.WriteLine("Cannot process - Order has been cancelled");
        }

        public void ShipOrder()
        {
            Console.WriteLine("Cannot ship - Order has been cancelled");
        }

        public void DeliverOrder()
        {
            Console.WriteLine("Cannot deliver - Order has been cancelled");
        }

        public void CancelOrder()
        {
            Console.WriteLine("Order is already cancelled");
        }
    }
}
