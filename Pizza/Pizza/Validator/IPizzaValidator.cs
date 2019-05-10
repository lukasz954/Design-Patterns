using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Decorator
{
    public interface IPizzaValidator
    {
        bool PizzaCountValid(Pizza pizza,int max);
    }
}
