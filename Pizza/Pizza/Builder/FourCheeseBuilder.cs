using System.Collections.Generic;

namespace Pizza
{
    public class FourCheeseBuilder : PizzaBuilder
    {

       
        public override void Name() => _pizza.Name="4 Cheese";
        public override void AddDough() => _pizza.Dough = $"{GetType().Name} Dough";
        public override void AddSauce() => _pizza.Sauce = $"{GetType().Name} Sauce";
        public override void SetCheese() => _pizza.Cheese = $"{GetType().Name} Cheese";
        public override void SetMeat() => _pizza.Meat = $"{GetType().Name} Meat";
        public override void SetVegetables() => _pizza.Vegetables = new List<string> { $"{GetType().Name} Veg1, {GetType().Name} Veg2" };
        
    }
}



