using FastFoodSimulator.Data;
using System.Collections.Concurrent;

namespace FastFoodSimulator.Services
{
    public class ServerService
    {
        private ConcurrentQueue<Customer> _customers;
        private ConcurrentQueue<Order> _preparedOrders;
        public ConcurrentQueue<Customer> Customers => _customers;

        public ServerService()
        {
            _customers = new ConcurrentQueue<Customer>();
            _preparedOrders = new ConcurrentQueue<Order>();
        }

        public void AddCustomer(Customer customer)
        {
            ArgumentNullException.ThrowIfNull(customer);

            _customers.Enqueue(customer);
        }

        public void AddOrder(Order order)
        {
            ArgumentNullException.ThrowIfNull(order);

            _preparedOrders.Enqueue(order);
        }

        public void ServeCustomer()
        {
            _customers.TryDequeue(out _);
            _preparedOrders.TryDequeue(out _);
        }
    }
}
