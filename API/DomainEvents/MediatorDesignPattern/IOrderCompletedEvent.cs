
namespace API.DomainEvents.MediatorDesignPattern
{
    public interface IOrderCompletedEvent
    {
        void OrderCompleted(Order order);
    }
}
