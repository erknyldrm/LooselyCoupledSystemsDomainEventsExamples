namespace API.DomainEvents.MediatorDesignPattern
{
    public class OrderMediator : IOrderCompletedEvent
    {
        readonly List<IOrderCompletedEvent> _eventListener = new();
        public void Register(IOrderCompletedEvent @event)
        {
            _eventListener.Add(@event);
        }

        public void OrderCompleted(Order order)
        {
            _eventListener.ForEach(e => e.OrderCompleted(order));
        }
    }
}
