using System.Collections.Generic;
using System.Linq;
using OrderService.Models;

namespace OrderService.Services
{
    public class OrderService
    {
        private readonly List<Order> _orders = new List<Order>();

        public List<Order> GetOrders()
        {
            return _orders;
        }

        public Order GetOrderById(string id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            var existingOrder = GetOrderById(order.Id);
            if (existingOrder != null)
            {
                existingOrder.Total = order.Total;
            }
        }

        public void DeleteOrder(string id)
        {
            var order = GetOrderById(id);
            if (order != null)
            {
                _orders.Remove(order);
            }
        }
    }
}