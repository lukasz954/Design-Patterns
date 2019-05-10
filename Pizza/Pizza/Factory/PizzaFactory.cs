using Pizza.Builder;
using Pizza.State;
using Pizza.Strategy;
using System;
using System.Collections.Generic;

namespace Pizza
{
    public class PizzaFactory : IPizzaFactory
    {
        private IPizzaBuildState _pizzaBuildState;
        private IOrderConstructor _orderConstructor;
        public PizzaFactory(IPizzaBuildState pizzaBuildState, IOrderConstructor orderConstructor)
        {
            _pizzaBuildState = pizzaBuildState;
            _orderConstructor = orderConstructor;
        }
        public Pizza MakePizza(Enum_Menu menu, Enum_PizzaType type)
        {            
            switch (menu)
            {
                case Enum_Menu.Margarita:
                    return CreatePizza(new MargaritaBuilder(), "Margarita",type);                    
                case Enum_Menu.Pepperoni:
                    return CreatePizza(new PepperoniBuilder(), "Pepperoni",type);                    
                case Enum_Menu.FourCheese:
                    return CreatePizza(new FourCheeseBuilder(), "4 Cheese",type);
                case Enum_Menu.CustomPizza:
                    return new Pizza();
                default:
                    throw new ArgumentOutOfRangeException();                    
            }
        }
        
        private Pizza CreatePizza(PizzaBuilder builder,string pizzaName,Enum_PizzaType type) 
        {
            var pizzaMaker = new PizzaMaker(builder,type, pizzaName, _pizzaBuildState, _orderConstructor);
            pizzaMaker.BuildPizza();
            return pizzaMaker.GetPizza();
        }
    }
}



