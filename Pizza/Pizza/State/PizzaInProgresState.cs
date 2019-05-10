namespace Pizza.State
{
    public class PizzaInProgresState : IOrderState
    {
        public string SetProgress() => $"Pizza Progress: {this.GetType().Name} Start build";
    }
}
