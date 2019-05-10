using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Builder
{
    public class CustomPizzaFluentBuilder
    {
        private Pizza _pizza;
        public CustomPizzaFluentBuilder(Pizza pizza)
        {
            _pizza = pizza;
        }
        public Pizza Build() => new Pizza(_pizza);

        public CustomPizzaFluentBuilder AddDough(string dough)
        {
            _pizza.Dough = dough;
            return this;
        }        
        public CustomPizzaFluentBuilder AddSauce(string sauce)
        {
            _pizza.Sauce = sauce;
            return this;
        }
        public CustomPizzaFluentBuilder SetCheese(string cheese)
        {
            _pizza.Cheese = cheese;
            return this;
        }
        public CustomPizzaFluentBuilder SetMeat(string meat)
        {
            _pizza.Meat = meat;
            return this;
        }
        public CustomPizzaFluentBuilder SetVegetables(List<string> vegetables)
        {
            _pizza.Vegetables = vegetables;
            return this;
        }
        public CustomPizzaFluentBuilder SetCount(int count)
        {
            _pizza.Count = count;
            return this;
        }        
    }
}