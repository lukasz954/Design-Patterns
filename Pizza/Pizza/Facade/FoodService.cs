using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Facade
{
   public class FoodService : ISubmitOrder
   {
        public void SubmitOrder()=>Console.WriteLine($"Zamówiono obiad z {GetType().Name}");
        
   }
}
