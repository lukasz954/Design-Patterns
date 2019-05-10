using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Proxy
{
    public class TraineeServer: IOrderService
    {
        private readonly Server _server;
        public TraineeServer(Server server)
        {
            _server = server;
        }

        public Pizza MakeOrder(Pizza pizza)
        {
            if (!OrderCountValidation(pizza))
                return _server.MakeOrder(pizza);
            else
                throw new Exception($"Osiągnięto limit {GetType().Name}.");
        }

        private bool OrderCountValidation(Pizza pizza)
        {
            return pizza.Count > 5 ? true : false;
        }
    }
}
