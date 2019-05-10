using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Singleton
{
    public sealed class PizzaProcessLogger
    {
        private static readonly PizzaProcessLogger _instance = new PizzaProcessLogger();

        static PizzaProcessLogger() { }

        private PizzaProcessLogger() { }

        public string LogMessage { get; set; }

        public static PizzaProcessLogger Instance => _instance;
        public static List<string> LogsList = new List<string>();
    }
}
