using System;
using System.Collections.Generic;
using Pizza.Builder;

namespace Pizza
{
    public class Pizza : ICloneable
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Cheese { get; set; }
        public string Meat { get; set; }
        public List<string> Vegetables { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

        public Pizza()
        {
            Name = GetType().Name;
        }
        
        public Pizza(Pizza customPizzaBuilder)
        {
            Dough = customPizzaBuilder.Dough;
            Sauce = customPizzaBuilder.Sauce;
            Cheese = customPizzaBuilder.Cheese;
            Meat = customPizzaBuilder.Meat;
            Vegetables = customPizzaBuilder.Vegetables;
            Count = customPizzaBuilder.Count;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}



