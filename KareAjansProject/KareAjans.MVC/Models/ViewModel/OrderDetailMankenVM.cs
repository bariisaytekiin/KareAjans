using KareAjans.Entity.Entities;

namespace KareAjans.MVC.Models.ViewModel
{
    public class OrderDetailMankenVM
    {
        public List<OrderDetail> OrderDetails { get; set; }

        public List<Manken> Mankenler { get; set; }

        public List <Order> Orders { get; set; }

    }
}
