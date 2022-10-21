using FastFoodSimulator.Data;
using System.Collections.Concurrent;

namespace FastFoodSimulator.Services
{
    public class KitchenService
    {
        public delegate void PrepareOrderHandler(int orderNumber);

        public event PrepareOrderHandler? OnPrepareOrder;

        public delegate void ChangeOrderHandler(ConcurrentQueue<Order> orders);

        public event ChangeOrderHandler? OnChangeOrder;

        private ConcurrentQueue<Order> _orders;
        public ConcurrentQueue<Order> Orders => _orders;

        public KitchenService()
        {
            _orders = new ConcurrentQueue<Order>();
        }

        public void AddOrder(Order order)
        {
            ArgumentNullException.ThrowIfNull(order);

            _orders.Enqueue(order);

            InvokeOnPrepareOrder(order.Receipt);
            InvokeOnChangeOrder();
        }

        public Order DeleteOrder()
        {
            Order order;
            _orders.TryDequeue(out order);

            InvokeOnChangeOrder();

            return order;
        }

        private void InvokeOnPrepareOrder(int orderNumber)
        {
            OnPrepareOrder?.Invoke(orderNumber);
        }

        private void InvokeOnChangeOrder()
        {
            OnChangeOrder?.Invoke(_orders);
        }
    }
}