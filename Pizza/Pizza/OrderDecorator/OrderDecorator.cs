using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{

    public class OrderDecorator : Order
    {
        protected Order _order;
        public OrderDecorator(Order order)
        {
            _order = order;
        }
        public override decimal CalculateCost()
        {
            return _order.CalculateCost();
        }

        public override decimal GetCost()
        {
           return _order.GetCost();
        }

        public override string GetDescription()
        {
           return _order.Description;
        }

        public override List<Pizza> GetPizzas()
        {
            return _order.GetPizzas();
        }

        public override List<Pizza> MakeOrder()
        {
            return _order.MakeOrder();
        }
    }
}
