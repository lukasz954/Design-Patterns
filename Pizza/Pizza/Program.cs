using Autofac;
using Autofac.Core.Activators.Reflection;
using Pizza.Strategy;
using System;
using System.Reflection;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();
            
            using (var scope = container.BeginLifetimeScope())
            {
                
                var app = scope.Resolve<Application>();
                app.Run();
            }

            Console.ReadKey();  
        }
    }
    
}



