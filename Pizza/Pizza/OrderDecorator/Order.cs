using System.Collections.Generic;

namespace Pizza
{
    public abstract class Order
    {
        public string Description { get; set; }
        public abstract decimal GetCost();
        public abstract string GetDescription();
        public abstract decimal CalculateCost();
        public abstract List<Pizza> MakeOrder();
        public abstract List<Pizza> GetPizzas();
    }
}
