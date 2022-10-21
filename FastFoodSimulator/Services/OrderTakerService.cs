using FastFoodSimulator.Data;
using System.Collections.Concurrent;

namespace FastFoodSimulator.Services
{
    public class OrderTakerService
    {
        public delegate void CustomersChangeHandler(int amount);

        public delegate void OrderTakenHandler(int orderNumber);

        public event CustomersChangeHandler? OnCustomersChange;

        public event OrderTakenHandler? OnOrderTake;

        private ConcurrentQueue<Customer> _customers;
        public ConcurrentQueue<Customer> Customers => _customers;

        public OrderTakerService()
        {
            _customers = new ConcurrentQueue<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            ArgumentNullException.ThrowIfNull(customer);

            _customers.Enqueue(customer);

            InvokeOnCustomersChange();
        }

        public Customer TakeOrderFromCustomer()
        {
            Customer customer;
            var result = _customers.TryDequeue(out customer);

            if (result)
            {
                var order = new Order(customer.Id);

                customer.CustomerOrder = order;

                InvokeOnCustomersChange();
                InvokeOnOrderTake(order.Receipt);
            }

            return customer;
        }

        private void InvokeOnOrderTake(int orderNumber)
        {
            OnOrderTake?.Invoke(orderNumber);
        }
        private void InvokeOnCustomersChange()
        {
            OnCustomersChange?.Invoke(_customers.Count);
        }
    }
}
