namespace API.DomainEvents.Delegate
{
    public class Order
    {

        public delegate void OrderCompletedEventHandler();


        public event OrderCompletedEventHandler OrderCompleted;


        public virtual void OnOrderCompleted()
        {
            OrderCompleted();
        }

        public void CompleteOrder()
        {
            OnOrderCompleted();
        }
    }
}
