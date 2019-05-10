namespace Pizza.Mediator
{
    public abstract class Colleague
    {
        protected Mediator _mediator;
        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }
        public abstract void Send(string message);
        public abstract void Notify(string message);
    }
    
}
