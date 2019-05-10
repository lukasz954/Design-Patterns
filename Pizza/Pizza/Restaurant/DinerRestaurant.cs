using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Restaurant
{
   public class DinerRestaurant:Restaurant
    {
        public DinerRestaurant()
        {
            OrderManager = new DinerRestaurantManager();
        }
    }
}
