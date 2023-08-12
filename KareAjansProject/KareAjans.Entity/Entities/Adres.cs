using KareAjans.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.Entity.Entities
{
    public class Adres:BaseEntity
    {
        [Required]
        public string AcikAdres { get; set; }
        [Required]
        public string Sehir { get; set; }
       

        //Mapping

        public List<Organizasyon> Organizasyonlar { get; set; }
    }
}
