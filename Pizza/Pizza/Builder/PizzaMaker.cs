using Pizza.Memento;
using Pizza.Singleton;
using Pizza.State;
using Pizza.Strategy;
using System;
using System.Collections.Generic;

namespace Pizza
{
    public class PizzaMaker
    {
        private  PizzaBuilder _builder;
        private  Enum_PizzaType _pizzaType;
        private  string _pizzaName;
        private IPizzaBuildState _pizzaBuildState;
        private IOrderConstructor orderCunstructor;

        public PizzaMaker(PizzaBuilder builder, Enum_PizzaType pizzaType, string pizzaName, IPizzaBuildState pizzaBuildState, IOrderConstructor orderCunstructor)
        {
            _builder = builder;
            _pizzaType = pizzaType;
            _pizzaName = pizzaName;
            _pizzaBuildState = pizzaBuildState;
            this.orderCunstructor = orderCunstructor;
        }

        private IOrderConstructor Constructor()
        {
            orderCunstructor.Builder = _builder;
            orderCunstructor.PizzaType = _pizzaType;
            orderCunstructor.PizzaName = _pizzaName;
            orderCunstructor.PizzaBuildState = _pizzaBuildState;
            
            return orderCunstructor;
        }
        public void BuildPizza()
        {
            Constructor().CreateOrder();
        }

        public Pizza GetPizza()
        {
            return _builder.Build();
        }
    }
}



