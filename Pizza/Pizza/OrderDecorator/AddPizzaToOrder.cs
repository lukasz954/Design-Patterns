using System.Collections.Generic;

namespace Pizza
{
    public class AddPizzaToOrder : OrderDecorator, IRemoveOrAddPizzaFromOrder
    {
        private int _number;
        private Pizza _pizza;
        public AddPizzaToOrder(Order order, int number, Pizza pizza) : base(order)
        {
            _number = number;
            _pizza = pizza;
        }

        public override decimal CalculateCost()
        {
            decimal cost = 0;
            decimal actualCost = _order.GetCost();
            var pizzasList = _order.GetPizzas();
            foreach (var pizza in pizzasList)
                cost += pizza.Price;
            return actualCost + cost;
        }
        public List<Pizza> UpdateOrder()
        {
            var pizzasList = _order.GetPizzas();
            for (int i = 0; i < _number; i++)
                pizzasList.Add(_pizza);
            return pizzasList;
        }

    }
}
