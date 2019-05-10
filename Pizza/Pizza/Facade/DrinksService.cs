using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Facade
{
    public class DrinksService : ISubmitOrder
    {
        public void SubmitOrder()=>Console.WriteLine($"Zamówiono kawe z {GetType().Name}");
    }
}
