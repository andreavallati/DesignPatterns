namespace State.States.Interfaces
{
    // State Pattern: State Interface
    // Declares methods that all concrete states must implement
    public interface IOrderState
    {
        void ProcessOrder();
        void ShipOrder();
        void DeliverOrder();
        void CancelOrder();
        string GetStateName();
    }
}
