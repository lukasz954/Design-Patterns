using Pizza.Strategy;

namespace Pizza
{
    public interface IPizzaFactory
    {
        Pizza MakePizza(Enum_Menu menu, Enum_PizzaType type);
    }
}



