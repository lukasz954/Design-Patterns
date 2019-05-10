namespace Pizza.State
{
    public class PizzaBuildState: IPizzaBuildState
    {
        private IOrderState _orderState;
        public string SetBuildingProgress(IOrderState orderState)
        {
            _orderState = orderState;
            return _orderState.SetProgress();
        }
    }
}
