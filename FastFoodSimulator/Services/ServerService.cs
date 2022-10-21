using FastFoodSimulator.Data;
using System.Collections.Concurrent;

namespace FastFoodSimulator.Services
{
    public class ServerService
    {
        public delegate void ServedCustomersChangeHandler(ConcurrentQueue<Customer> customers);

        public delegate void PreparedOrderHandler(int ordersNumber);

        public event ServedCustomersChangeHandler? OnServedCustomersChange;

        public event PreparedOrderHandler? OnPreparedOrderTake;

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

            InvokeOnServedCustomersChange();
        }

        public void AddOrder(Order order)
        {
            ArgumentNullException.ThrowIfNull(order);

            _preparedOrders.Enqueue(order);
        }

        public void ServeCustomer()
        {
            _customers.TryDequeue(out _);

            Order order;
            _preparedOrders.TryDequeue(out order);

            if (order != null)
            {
                InvokeOnServedCustomersChange();
                InvokeOnPreparedOrderTake(order.Id);
            }
        }

        private void InvokeOnPreparedOrderTake(int orderNumber)
        {
            OnPreparedOrderTake?.Invoke(orderNumber);
        }

        private void InvokeOnServedCustomersChange()
        {
            OnServedCustomersChange?.Invoke(_customers);
        }
    }
}
