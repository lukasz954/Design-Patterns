namespace Pizza.State
{
    public interface IPizzaBuildState
    {
        string SetBuildingProgress(IOrderState orderState);
    }
}
