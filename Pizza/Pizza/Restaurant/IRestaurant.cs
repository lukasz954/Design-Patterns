using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Restaurant
{
    public interface IRestaurant
    {
        void NormalOrder();
        void DairyFreeOrder();
        void GlutenFreeOrder();
    }
}
