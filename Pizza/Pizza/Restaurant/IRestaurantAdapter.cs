using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Restaurant
{
    public interface IRestaurantAdapter
    {
        void NormalOrder(OrderMenagerAdapter orderMenager);
        void DairyFreeOrder(OrderMenagerAdapter orderMenager);
        void GlutenFreeOrder(OrderMenagerAdapter orderMenager);
    }
}
