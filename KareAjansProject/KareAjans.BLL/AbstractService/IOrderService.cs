using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.AbstractService
{
    public interface IOrderService
    {
        string CreateOrder(Order order);

        //List
        IEnumerable<Order> GetAllOrders();
        //Find
        Order FindOrder(int id);

    }
}
