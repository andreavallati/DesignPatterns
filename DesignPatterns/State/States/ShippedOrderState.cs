using State.Models;
using State.States.Interfaces;

namespace State.States
{
    // Concrete State: Shipped Order State
    public class ShippedOrderState : IOrderState
    {
        private readonly Order _order;

        public ShippedOrderState(Order order)
        {
            _order = order ?? throw new ArgumentNullException(nameof(order));
        }

        public string GetStateName() => "Shipped";

        public void ProcessOrder()
        {
            Console.WriteLine("Order has already been processed");
        }

        public void ShipOrder()
        {
            Console.WriteLine("Order has already been shipped");
        }

        public void DeliverOrder()
        {
            Console.WriteLine("Order is being delivered...");
            _order.SetState(new DeliveredOrderState(_order));
        }

        public void CancelOrder()
        {
            Console.WriteLine("Cannot cancel - Order has already been shipped");
        }
    }
}
