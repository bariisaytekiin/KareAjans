using KareAjans.Entity.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.Entity.Entities
{
    public class Order:BaseEntity
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

        public string OrganizasyonNumarasi { get; set; }
        public bool Onaylama { get; set; }
        public string OrganizasyonAdresi { get; set; }
        public string OrganizasyonSehirAdresi { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public string? UserId { get; set; }

        public IdentityUser User { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
