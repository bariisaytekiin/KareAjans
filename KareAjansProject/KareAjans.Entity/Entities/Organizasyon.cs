using KareAjans.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.Entity.Entities
{
    public class Organizasyon:BaseEntity
    {

        public Organizasyon()
        {
            OrganizasyonGiderleri = new List<OrganizasyonGider>();
        }

        [Required]
        [MaxLength(100)]
        public string OrganizasyonAdi { get; set; }
        [Required]
        public DateTime BaslangicTarihi { get; set; }
        [Required]
        public DateTime BitisTarihi { get; set; }
        
        public int? AdresId { get; set; }




        //Mapping
        public Adres Adres{ get; set; }
        public List<OrganizasyonGelir> OrganizasyonGelir { get; set; }
        public List<OrganizasyonGider> OrganizasyonGiderleri { get; set; }
    }
}
