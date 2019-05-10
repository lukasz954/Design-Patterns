using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Restaurant
{
    public class Restaurant:IRestaurant,IRestaurantAdapter
    {
        private OrderManager _orderMenager;
        protected OrderManager OrderManager
        {
            get => _orderMenager;
            set
            {
                _orderMenager = value;
                Console.WriteLine($"Plugging {OrderManager.GetType().Name} into {this.GetType().Name} console.");
            }
        }
        public void NormalOrder() => Console.WriteLine($"{GetType().Name} Normal Order");
        public void DairyFreeOrder() => Console.WriteLine($"{GetType().Name} Dairy Free Order");
        public void GlutenFreeOrder() => Console.WriteLine($"{GetType().Name} Gluten Free Order");
        public void NormalOrder(OrderMenagerAdapter orderMenager) => Console.WriteLine($"{GetType().Name} Normal Order");
        public void DairyFreeOrder(OrderMenagerAdapter orderMenager) => Console.WriteLine($"{GetType().Name} Dairy Free Order");
        public void GlutenFreeOrder(OrderMenagerAdapter orderMenager) => Console.WriteLine($"{GetType().Name} Gluten Free Order");
    }
}
