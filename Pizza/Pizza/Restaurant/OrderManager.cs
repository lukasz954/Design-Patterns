using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Restaurant
{
    public interface IOrder { }
    public class OrderManager : IOrder { }
    public class LunchRestaurantManager : OrderManager { }
    public class DinerRestaurantManager : OrderManager { }   
}
