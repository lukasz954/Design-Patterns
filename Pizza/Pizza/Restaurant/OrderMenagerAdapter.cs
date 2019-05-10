using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Restaurant
{
    public class OrderMenagerAdapter
    {
        public OrderManager OrderManager { get; set; }
        public OrderMenagerAdapter(OrderManager orderManager)
        {
            OrderManager = orderManager;
            Console.WriteLine($"Zamówienie z {orderManager.GetType().Name}.");
        }
    }
}
