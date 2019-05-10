namespace Pizza
{
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;
        public Pizza Build()
        {
            return _pizza;
        }
        public void CreateNewPizza()
        {
            _pizza = new Pizza();
        }
        
        public abstract void Name();
        public abstract void AddDough();
        public abstract void AddSauce();
        public abstract void SetCheese();
        public abstract void SetMeat();
        public abstract void SetVegetables();
      
    }
}



