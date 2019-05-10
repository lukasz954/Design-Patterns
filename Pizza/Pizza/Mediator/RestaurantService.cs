using Pizza.State;
using Pizza.Strategy;
using System;

namespace Pizza.Mediator
{
    public class RestaurantService : Colleague
    {
        IPizzaFactory _pizzaFactory;
        Enum_Menu _pizzaType;
        Enum_PizzaType _pizza;
        Pizza pizza;
        IPizzaBuildState _pizzaBuildState;
        IOrderConstructor _orderConstructor;
        public RestaurantService(Mediator mediator, Enum_Menu pizzaType, Enum_PizzaType pizza, IPizzaBuildState pizzaBuildState, IOrderConstructor orderConstructor) : base(mediator)
        {
            _orderConstructor = orderConstructor;//gggggggggggggggggggggggggggggggggggggggggg
            _pizzaBuildState = pizzaBuildState;
            _pizzaFactory = new PizzaFactory(_pizzaBuildState, _orderConstructor);
            _pizzaType = pizzaType;
            _pizza = pizza;
        }

        public override void Notify(string message)
        {
            if (pizza is null)
                pizza = _pizzaFactory.MakePizza(_pizzaType, _pizza);
            Console.WriteLine($"{GetType().Name} message: {message}");
        }

        public override void Send(string message)
        {
            _mediator.SendMessage(message, this);
        }
    }
    
}
