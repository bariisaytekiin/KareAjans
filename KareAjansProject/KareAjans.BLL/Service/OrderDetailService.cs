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
    public class OrderDetailService : IOrderDetailService
    {
        private IRepository<OrderDetail> _orderDetailRepository;

        public OrderDetailService(IRepository<OrderDetail> repository)
        {
            _orderDetailRepository = repository;
        }


        //Sipariş Detay Oluşturma
        public string CreateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                _orderDetailRepository.Create(orderDetail);
                return "sipariş detayı oluşturuldu!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return _orderDetailRepository.GetAll();
        }
    }
}
