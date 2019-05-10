using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Facade
{
   public class RestaurantFacade
   {
        public void GetOrder(Enum_OrderType type)
        {
            switch (type)
            {
                case Enum_OrderType.Drinks:
                     DrinksService();
                    break;
                case Enum_OrderType.Food:
                     FoodService();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void DrinksService()
        {
           var drinkService= new DrinksService();
           drinkService.SubmitOrder();
        }
        private void FoodService()
        {
           var ds= new FoodService();
           ds.SubmitOrder();
        }
    }
}
