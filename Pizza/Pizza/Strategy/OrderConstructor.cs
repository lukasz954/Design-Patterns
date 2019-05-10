using Pizza.Singleton;
using Pizza.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Strategy
{
    public class OrderConstructor : IOrderConstructor
    {
        private PizzaBuilder _builder;
        private Enum_PizzaType _pizzaType;
        private string _pizzaName;
        private IPizzaBuildState _pizzaBuildState;

        public PizzaBuilder Builder { get=> _builder; set=> _builder=value; }
        public Enum_PizzaType PizzaType { get=>_pizzaType; set=> _pizzaType=value; }
        public string PizzaName { get=> _pizzaName; set=> _pizzaName=value; }
        public IPizzaBuildState PizzaBuildState { get => _pizzaBuildState; set=>_pizzaBuildState=value; }
        public OrderConstructor(PizzaBuilder builder, Enum_PizzaType pizzaType, string pizzaName, IPizzaBuildState pizzaBuildState)
        {
            _builder = builder;
            _pizzaName = pizzaName;
            _pizzaType = pizzaType;
            _pizzaBuildState = pizzaBuildState;
        }

        public void CreateOrder()
        {
            IBuildPizzaStrategy strategy = null;
            switch (_pizzaType)
            {
                case Enum_PizzaType.Vegan:
                    {
                        strategy = new VeganPizza(_builder, _pizzaBuildState);
                        strategy.BuildPizza(_pizzaName);
                    }
                    break;
                case Enum_PizzaType.GlutenFree:
                    {
                        strategy = new PizzaWithoutGluten(_builder, _pizzaBuildState);
                        strategy.BuildPizza(_pizzaName);
                    }
                    break;
                case Enum_PizzaType.Normal:
                    {
                        strategy = new NormalPizza(_builder, _pizzaBuildState);
                        strategy.BuildPizza(_pizzaName);
                    }
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
