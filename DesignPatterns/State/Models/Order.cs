using State.States.Interfaces;

namespace State.Models
{
    // Context: Maintains current state and delegates behavior to it
    public class Order
    {
        private IOrderState _currentState = null!;

        public Order(IOrderState? initialState)
        {
            if (initialState != null)
            {
                _currentState = initialState;
                Console.WriteLine($"Order created in '{_currentState.GetStateName()}' state");
            }
        }

        public string CurrentStateName => _currentState.GetStateName();

        public void SetState(IOrderState newState)
        {
            if (_currentState != null)
            {
                Console.WriteLine($"State transition: '{_currentState.GetStateName()}' -> '{newState.GetStateName()}'");
            }
            else
            {
                Console.WriteLine($"Order initialized in '{newState.GetStateName()}' state");
            }
            _currentState = newState;
        }

        // Context methods delegate to current state
        public void ProcessOrder()
        {
            Console.WriteLine($"\n[Action] Processing order (Current: {CurrentStateName})");
            _currentState.ProcessOrder();
        }

        public void ShipOrder()
        {
            Console.WriteLine($"\n[Action] Shipping order (Current: {CurrentStateName})");
            _currentState.ShipOrder();
        }

        public void DeliverOrder()
        {
            Console.WriteLine($"\n[Action] Delivering order (Current: {CurrentStateName})");
            _currentState.DeliverOrder();
        }

        public void CancelOrder()
        {
            Console.WriteLine($"\n[Action] Cancelling order (Current: {CurrentStateName})");
            _currentState.CancelOrder();
        }
    }
}
