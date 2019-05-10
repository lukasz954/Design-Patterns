using System;
using System.Collections.Generic;
using System.Linq;

namespace Pizza.Memento
{
    public class PizzaBuilderManager
    {
        private readonly List<IMemento> _mementos = new List<IMemento>();
        private readonly Build _build;
        
        public PizzaBuilderManager(Build build)
        {
            _build = build;
        }

        public void SaveCurrentBuild() => _mementos.Add(_build.Save());
        public void Undo(string pizzaName)
        {
            if (_mementos.Count == 0)
                return;
            var memento = _mementos.Last(c=>c.State.Contains(pizzaName));
            _mementos.Remove(memento);
            try
            {
                _build.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo(pizzaName);
            }
        }

        public void ShowHistory()
        {
            foreach (var memento in _mementos)
                 Console.WriteLine(memento.State);
        }
        

    }

}
