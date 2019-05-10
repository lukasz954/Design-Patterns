using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Decorator
{
    public class PizzaValidator: IPizzaValidator
    {
        public void AddNumber(Pizza pizza)
        {
           ++pizza.Count;
        }
        public bool PizzaCountValid(Pizza pizza,int max)
        {
            if (pizza.Count >= max)
                return true;
            else
            {
                AddNumber(pizza);
                return false;
            }
        }
        
    }
}
