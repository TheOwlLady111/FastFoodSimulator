﻿using FastFoodSimulator.Data;
using System.Collections.Concurrent;

namespace FastFoodSimulator.Services
{
    public class KitchenService
    {
        public delegate void PrepareOrderHandler(int orderNumber);

        public event PrepareOrderHandler? OnPrepareOrder;

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
        }

        public Order DeleteOrder()
        {
            Order order;
            _orders.TryDequeue(out order);
            return order;
        }

        private void InvokeOnPrepareOrder(int orderNumber)
        {
            OnPrepareOrder?.Invoke(orderNumber);
        }
    }
}