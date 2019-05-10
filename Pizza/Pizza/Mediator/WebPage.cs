using System;

namespace Pizza.Mediator
{
    public class WebPage : Colleague
    {
        public WebPage(Mediator mediator) : base(mediator)
        {
           
        }

        public override void Notify(string message)=>Console.WriteLine($"{GetType().Name} message: {message}");
        
        public override void Send(string message)=> _mediator.SendMessage(message, this);
        
    }
    
}
