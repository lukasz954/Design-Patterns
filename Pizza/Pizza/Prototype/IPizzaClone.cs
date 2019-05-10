using System.Collections.Generic;

namespace Pizza.Prototype
{
    public interface IPizzaClone
    {
        IEnumerable<Pizza> GetPizzaCloneList(object pizza, int pizzaCount);
    }
}