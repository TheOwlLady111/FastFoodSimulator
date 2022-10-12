using FastFoodSimulator.Data;
using System.Collections.Concurrent;

namespace FastFoodSimulator.Services
{
    public class OrderTakerService
    {
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
        }

        public Customer TakeOrderFromCustomer()
        {
            Customer customer;
            var result = _customers.TryDequeue(out customer);

            if (result)
            {
                var order = new Order(customer.Id);

                customer.CustomerOrder = order;
            }

            return customer;
        }

    }
}
