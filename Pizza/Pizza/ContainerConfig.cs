using Autofac;
using Autofac.Core;
using Pizza.Decorator;
using Pizza.Prototype;
using Pizza.State;
using Pizza.Strategy;

namespace Pizza
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().AsSelf();
            builder.RegisterType<OrderConstructor>().AsSelf();
            builder.RegisterType<PizzaValidator>().As<IPizzaValidator>();
            builder.RegisterType<PizzaClone>().As<IPizzaClone>();
            builder.RegisterType<PizzaBuildState>().As<IPizzaBuildState>();
            builder.RegisterType<OrderConstructor>().As<IOrderConstructor>()
                .WithParameter(new TypedParameter(typeof(PizzaBuilder), default(PizzaBuilder)))
                .WithParameter(new TypedParameter(typeof(Enum_PizzaType), default(Enum_PizzaType)))
                .WithParameter(new TypedParameter(typeof(string), string.Empty))
                .WithParameter(new TypedParameter(typeof(IPizzaBuildState), default(IPizzaBuildState)));

            return builder.Build();
        }
    }
    
}



