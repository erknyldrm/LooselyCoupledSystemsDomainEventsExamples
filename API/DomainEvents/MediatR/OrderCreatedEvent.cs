namespace API.DomainEvents.MediatR
{
    public class OrderCreatedEvent : IDomainEvent
    {
        public Guid OrderId { get; set; }
        public List<object> OrderItems { get; set; }
    }
}
