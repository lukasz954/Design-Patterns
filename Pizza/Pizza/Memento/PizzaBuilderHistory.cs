using System;

namespace Pizza.Memento
{
    public class PizzaBuilderHistory : IMemento
    {
        public PizzaBuilderHistory(string state)
        {
            State = state;
            Date = DateTime.Now;
        }
        public DateTime Date {get;}
        public string State { get; }
        
    }

}
