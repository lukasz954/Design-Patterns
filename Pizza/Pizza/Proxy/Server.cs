using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Proxy
{
    public class Server : IOrderService
    {
        public Pizza MakeOrder(Pizza pizza) => pizza;
        
    }
}
