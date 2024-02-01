using Core.Domain;
using Core.Models;
using Core.Repository;
using Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository<Orders> _orderRepository;
        public OrderService(IOrderRepository<Orders> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Orders CreateOrder(Orders model)
        {
            return _orderRepository.CreateOrder(model);
        }

        public IEnumerable<Orders> GetOrderHistory(string Symbol)
        {
            return _orderRepository.GetOrdersHistory(Symbol);
        }
    }
   
}
