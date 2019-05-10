using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Strategy
{
    public interface IBuildPizzaStrategy
    {
        void BuildPizza(string pizzaName);
    }
}
