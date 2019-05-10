using Pizza.Decorator;
using System.Collections.Generic;

namespace Pizza.Prototype
{
    public class PizzaClone : IPizzaClone
    {

        private IPizzaValidator _pizza;
        public PizzaClone(IPizzaValidator pizza)
        {
            _pizza = pizza;
        }
        public IEnumerable<Pizza> GetPizzaCloneList(object pizza, int pizzaCount)
        {
            var pizzaList = new List<Pizza>();
            int maxNumberPizzasPerDay = 2;

            for (int i = 0; i < pizzaCount; i++)
            {
                if (_pizza.PizzaCountValid((Pizza)pizza, maxNumberPizzasPerDay))
                    break;
                pizzaList.Add((Pizza)pizza);
            }

            return pizzaList;
        }
    }
}
