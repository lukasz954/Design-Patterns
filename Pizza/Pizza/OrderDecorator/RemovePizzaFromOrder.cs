using System.Collections.Generic;

namespace Pizza
{
    public class RemovePizzaFromOrder : OrderDecorator, IRemoveOrAddPizzaFromOrder
    {
        private int _number;
        public RemovePizzaFromOrder(Order order, int number) : base(order)
        {
            _number = number;
        }

        public override decimal CalculateCost()
        {
            decimal cost = 0;
            decimal actualCost = _order.GetCost();
            var pizzasList = _order.GetPizzas();
            foreach (var pizza in pizzasList)
                cost += pizza.Price;
            return actualCost - cost;
        }
        public List<Pizza> UpdateOrder()
        {
            var pizzasList = _order.GetPizzas();
            for (int i = 0; i < _number; i++)
                pizzasList.RemoveAt(i);
            return pizzasList;
        }
    }
}
