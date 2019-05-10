namespace Pizza.Mediator
{
    public abstract class Mediator
    {
        public abstract void SendMessage(string message, Colleague restaurantAdapter);
    }
    
}
