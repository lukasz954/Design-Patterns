using Pizza.Builder;
using Pizza.Facade;
using Pizza.Mediator;
using Pizza.Memento;
using Pizza.Prototype;
using Pizza.Proxy;
using Pizza.Restaurant;
using Pizza.Singleton;
using Pizza.State;
using Pizza.Strategy;
using System;

namespace Pizza
{
    public class Application
    {
        private IPizzaClone _clone;
        private IPizzaBuildState _pizzaBuildState;
        private IOrderConstructor _orderConstructor;
         
        public Application(IPizzaClone clone, IPizzaBuildState pizzaBuildState, IOrderConstructor orderConstructor)
        {
            _clone = clone;
            _pizzaBuildState = pizzaBuildState;
            _orderConstructor = orderConstructor;
        }
       
        public void Run()
        {
            var pizzaFactory = new PizzaFactory(_pizzaBuildState, _orderConstructor);
            var margarita = pizzaFactory.MakePizza(Enum_Menu.Pepperoni, Enum_PizzaType.GlutenFree);

            
            var order = new NormalOrder(5, new Pizza { Price = 12 });
            var makeOrder = order.MakeOrder();
            var calculateCost = order.CalculateCost();

            var removePizzaFromOrder = new RemovePizzaFromOrder(order, 2);
            var updateOrderAfterRemovePizza = removePizzaFromOrder.UpdateOrder();
            var calculateCostAfterRemovePizza = removePizzaFromOrder.CalculateCost();

            var addPizzaToOrder = new AddPizzaToOrder(removePizzaFromOrder, 7, new Pizza { Price = 22 });
            var updateOrdeAfterAddPizzaToOrder = addPizzaToOrder.UpdateOrder();
            var calculateCostAfterAddPizzaToOrder = addPizzaToOrder.CalculateCost();


            var custom = pizzaFactory.MakePizza(Enum_Menu.CustomPizza, Enum_PizzaType.GlutenFree);
            var customPizza = new CustomPizzaFluentBuilder(custom)
                                                            .AddDough("Custom Dough")
                                                            .AddSauce("Custom Sauce")
                                                            .SetCheese("Custom Cheese")
                                                            .Build();


            int pizzaCount = 3;
            var pizzaList = _clone.GetPizzaCloneList(margarita.Clone(), pizzaCount);

            var restaurantFacade = new RestaurantFacade();
            restaurantFacade.GetOrder(Enum_OrderType.Drinks);

            var traineeServer = new TraineeServer(new Server());
            traineeServer.MakeOrder(new Pizza { Count = 3 });

            var mediator = new OrderMediator();
            var pizzaType = Enum_Menu.Pepperoni;
            var pizza = Enum_PizzaType.Normal;
            var webPage = new WebPage(mediator);
            var restaurantService = new RestaurantService(mediator, pizzaType, pizza,_pizzaBuildState, _orderConstructor);
            mediator.Restaurant = restaurantService;
            mediator.WebPage = webPage;

            var orderManager = new OrderManager();
            var orderManagerAdapter = new OrderMenagerAdapter(orderManager);
            var orderFromAdapter = orderManagerAdapter.OrderManager;


            PizzaProcessLogger.LogsList.Clear();
            var log = PizzaProcessLogger.LogsList;
            Build build = new Build(string.Empty);
            PizzaBuilderManager pizzaBuilderManager = new PizzaBuilderManager(build);
            Action saveCurrentBuild = () => pizzaBuilderManager.SaveCurrentBuild();

            webPage.Send($"Poproszę pizze: {pizzaType.ToString()}");
            restaurantService.Send("Zamówienie zostało przekazane");
            webPage.Send("Czy mogę zobaczyc proces tworzenia pizzy");
            restaurantService.Send("Tak, proszę bardzo");
            for (int i = 0; i < PizzaProcessLogger.LogsList.Count; i++)
            {
                build.SetState(log[i]);
                pizzaBuilderManager.SaveCurrentBuild();
                saveCurrentBuild.Invoke();
                Console.WriteLine(log[i]);
            }
            webPage.Send("Chciałbym pizze bez ostatniego składnika, czy to możliwe?");
            restaurantService.Send("Tak, oczywiście! bardzo proszę");
            pizzaBuilderManager.Undo(pizzaType.ToString());
            webPage.Send("Dziękuję");
        }

    }
    
}



