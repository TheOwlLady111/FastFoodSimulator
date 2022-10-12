using FastFoodSimulator.Data;

namespace FastFoodSimulator.Services
{
    public class ManagerService
    {
        private static OrderTakerService _orderTakerService;
        private static KitchenService _kitchenService;
        private static ServerService _serverService;

        static ManagerService()
        {
            _serverService = new ServerService();
            _kitchenService = new KitchenService();
            _orderTakerService = new OrderTakerService();
        }

        public void StartManage(CancellationToken token, int timeUser, int timeOrder, int timeFood, int timeServe)
        {
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

                    Thread.Sleep(timeOrder);

                    _kitchenService.AddOrder(customer.CustomerOrder);
                    _serverService.AddCustomer(customer);
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
