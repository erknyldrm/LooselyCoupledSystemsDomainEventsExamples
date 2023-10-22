namespace API.DomainEvents.MediatorDesignPattern
{
    public class SmsService : IOrderCompletedEvent
    {
        public void OrderCompleted(Order order)
        {
            //SmsSent
        }
    }
}
