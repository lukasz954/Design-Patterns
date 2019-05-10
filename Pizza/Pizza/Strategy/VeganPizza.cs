using Pizza.Singleton;
using Pizza.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Strategy
{
    public class VeganPizza: IBuildPizzaStrategy
    {
        private IPizzaBuildState _pizzaBuildState;
        private readonly PizzaBuilder _builder;
        public VeganPizza(PizzaBuilder builder, IPizzaBuildState pizzaBuildState)
        {
            _builder = builder;
            _pizzaBuildState = pizzaBuildState;
        }
        public void BuildPizza(string pizzaName)
        {
            var listLogs = PizzaProcessLogger.LogsList;
            var currentState = _pizzaBuildState.SetBuildingProgress(new PizzaInProgresState());
            listLogs.Add($"{DateTime.Now}, {currentState}");

            _builder.CreateNewPizza();
            listLogs.Add($"{DateTime.Now}, {this.GetType().Name}: {pizzaName} - Create New Pizza VeganPizza");
            _builder.Name();
            _builder.AddDough();
            listLogs.Add($"{DateTime.Now}, {this.GetType().Name}: {pizzaName} - Add Dough");
            _builder.AddSauce();
            listLogs.Add($"{DateTime.Now}, {this.GetType().Name}: {pizzaName} - Add Sauce");
            _builder.SetCheese();
            listLogs.Add($"{DateTime.Now}, {this.GetType().Name}: {pizzaName} - Set Cheese");
            _builder.SetVegetables();
            listLogs.Add($"{DateTime.Now}, {this.GetType().Name}: {pizzaName} - Set Vegetables");

            currentState = _pizzaBuildState.SetBuildingProgress(new PizzaDoneState());
            listLogs.Add($"{DateTime.Now}, {currentState}");
        }
    }
}
