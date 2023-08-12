using KareAjans.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.Entity.Entities
{
    public class OrderDetail:BaseEntity
    {
        public int MankenId { get; set; }
        public int OrderId { get; set; }

        public Manken Manken { get; set; }
        public Order Order { get; set; }

        public KareAjans.Entity.Enums.MankenKategori Kategori { get; set; }
    }
}
