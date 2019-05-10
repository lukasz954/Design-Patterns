using Pizza.State;

namespace Pizza.Strategy
{
    public interface IOrderConstructor
    {
        PizzaBuilder Builder { get; set; }
        IPizzaBuildState PizzaBuildState { get; set; }
        string PizzaName { get; set; }
        Enum_PizzaType PizzaType { get; set; }

        void CreateOrder();
    }
}