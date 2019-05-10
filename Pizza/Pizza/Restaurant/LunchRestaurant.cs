using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Restaurant
{
    public class LunchRestaurant: Restaurant
    {
        public LunchRestaurant()
        {
            OrderManager = new DinerRestaurantManager();
        }
    }
}
