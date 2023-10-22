namespace API.DomainEvents.EventHandlers
{
    public class OrderEventArgs : EventArgs
    {
        public Order Order { get; set; }

        public OrderEventArgs(Order order)
        {
            Order = order;
        }


    }
}
