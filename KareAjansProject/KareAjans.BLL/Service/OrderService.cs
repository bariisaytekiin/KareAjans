using KareAjans.BLL.Abstract;
using KareAjans.BLL.AbstractService;
using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.Service
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> repository)
        {
            _orderRepository = repository;
        }




        public string CreateOrder(Order order)
        {
            try
            {
                return _orderRepository.Create(order);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }


        Order IOrderService.FindOrder(int id)
        {
            return _orderRepository.GetById(id);
        }

      
    }
}
