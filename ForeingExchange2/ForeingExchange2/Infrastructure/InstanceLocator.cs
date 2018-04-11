using ForeingExchange2.ViewModels;


namespace ForeingExchange2.Infrastructure
{
   

   public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel(); 
        }
    }
}
