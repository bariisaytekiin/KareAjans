using KareAjans.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.Entity.Entities
{
    public class Yorum:BaseEntity
    {
       
        public string? Mesaj { get; set; }

        public int MankenId { get; set; }

        //Mapping
        public Manken Manken { get; set; }
    }
}
