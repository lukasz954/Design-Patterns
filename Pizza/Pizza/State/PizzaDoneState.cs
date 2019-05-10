namespace Pizza.State
{
    public class PizzaDoneState : IOrderState
    {
        public string SetProgress()=> $"Pizza Progress: {this.GetType().Name} End build";
    }
}
