namespace Pizza.Mediator
{
    public class OrderMediator : Mediator
    {
        private RestaurantService _restaurant;
        private WebPage _webPage;
        public RestaurantService Restaurant
        {
            set => _restaurant = value;
        }
        public WebPage WebPage
        {
            set => _webPage = value;
        }
        public override void SendMessage(string message, Colleague colleague)
        {
            if (colleague == _restaurant)
            {
                _restaurant.Notify(message);
            }
            else
            {
                _webPage.Notify(message);
            }
        }
    }
    
}
