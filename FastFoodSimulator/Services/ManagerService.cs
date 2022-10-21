using FastFoodSimulator.Data;

namespace FastFoodSimulator.Services
{
    public class ManagerService
    {
        public static OrderTakerService _orderTakerService;
        public static KitchenService _kitchenService;
        public static ServerService _serverService;

        private  const int timeOrder = 1500;
        private const int timeServe = 1000;

        static ManagerService()
        {
            _serverService = new ServerService();
            _kitchenService = new KitchenService();
            _orderTakerService = new OrderTakerService();
        }

        public void StartManage(CancellationToken token, int timeUser, int timeFood)
        {
            timeUser *= 1000;
            timeFood *= 1000;

            var taskGenerateCustomer= new Task(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    var customer = new Customer();
                    _orderTakerService.AddCustomer(customer);
                    Thread.Sleep(timeUser);
                }
            });

            var taskCreateOrder = new Task(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    var customer = _orderTakerService.TakeOrderFromCustomer();

                    if(customer != null)
                    {
                        Thread.Sleep(timeOrder);
                        _kitchenService.AddOrder(customer.CustomerOrder);
                        _serverService.AddCustomer(customer);
                    }
                }
            });

            var taskPreparationFood = new Task(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Thread.Sleep(timeFood);
                    var order = _kitchenService.DeleteOrder();
                    _serverService.AddOrder(order);
                }
            });

            var taskServerCustomer = new Task(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Thread.Sleep(timeServe);
                    _serverService.ServeCustomer();
                }
            });

            taskGenerateCustomer.Start();
            taskCreateOrder.Start();
            taskPreparationFood.Start();
            taskServerCustomer.Start();
        }
    }
}
