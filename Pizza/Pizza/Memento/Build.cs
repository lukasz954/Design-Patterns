using System;

namespace Pizza.Memento
{
    public class Build
    {
        private string _state;
        
        public Build(string state)
        {
            _state = state;
        }
        public string SetState(string state)
        {
            _state = state;
            return _state;
        }
        public IMemento Save() => new PizzaBuilderHistory(_state);
        public void Restore(IMemento memento)
        {
            var builderHistory = memento as PizzaBuilderHistory;
            if (builderHistory is null)
                throw new Exception($"Nie znaleziono klasy {memento}");
            _state = memento.State;
            Console.WriteLine("Ostatnio dodany składnik:" + memento.State);
        }
    }

}
