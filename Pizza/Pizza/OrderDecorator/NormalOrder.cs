using System.Collections.Generic;

namespace Pizza
{
    public class NormalOrder : Order
    {
        private int _number;
        private List<Pizza> _pizzasList;
        private Pizza _pizza;
        private decimal _cost;
        public override List<Pizza> GetPizzas()
        {
            return _pizzasList;
        }
        public override decimal GetCost()
        {
           return _cost;
        }
        public NormalOrder(int number,Pizza pizza)
        {
            Description = "Normal order";
            _number = number;
            _pizza = pizza;
            _pizzasList = new List<Pizza>();
        }
       public override decimal CalculateCost()
       {
            foreach (var pizza in _pizzasList)
            {
                _cost += _pizza.Price;
            }
            return _cost;
       }

        public override string GetDescription()
        {
            return Description;
        }

        public override List<Pizza> MakeOrder()
        {
            for (int i = 0; i < _number; i++)
                _pizzasList.Add(_pizza);
            return _pizzasList;
        }
    }
}
