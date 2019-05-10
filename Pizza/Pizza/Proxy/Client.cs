using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Proxy
{
    public class Client
    {
        public void ClientCode(IOrderService service,Pizza pizza)
        {
            service.MakeOrder(pizza);
        }
    }
}
