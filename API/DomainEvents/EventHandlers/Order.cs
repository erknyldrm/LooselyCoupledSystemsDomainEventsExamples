namespace API.DomainEvents.EventHandlers
{
    public class Order
    {
        public event EventHandler<OrderEventArgs> OrderCompleted; 

        public virtual void OnOrderCompleted(OrderEventArgs e)
        {
            OrderCompleted(this, e);
        }

        public void CompleteOrder()
        {
            OnOrderCompleted(new OrderEventArgs(this));
        }
    }
}
