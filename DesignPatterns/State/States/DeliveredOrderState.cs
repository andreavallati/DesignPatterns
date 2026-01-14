using State.Models;
using State.States.Interfaces;

namespace State.States
{
    // Concrete State: Delivered Order State
    public class DeliveredOrderState : IOrderState
    {
        private readonly Order _order;

        public DeliveredOrderState(Order order)
        {
            _order = order ?? throw new ArgumentNullException(nameof(order));
        }

        public string GetStateName() => "Delivered";

        public void ProcessOrder()
        {
            Console.WriteLine("Order has already been delivered");
        }

        public void ShipOrder()
        {
            Console.WriteLine("Order has already been delivered");
        }

        public void DeliverOrder()
        {
            Console.WriteLine("Order has already been delivered");
        }

        public void CancelOrder()
        {
            Console.WriteLine("Cannot cancel - Order has been delivered");
        }
    }
}
