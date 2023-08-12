using KareAjans.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.Entity.Entities
{
    public class OrganizasyonGelir:BaseEntity
    {
        [Required]
        public int OrganizasyonId { get; set; }
        [Required]
        public decimal Butce { get; set; }

        public Organizasyon Organizasyon { get; set; }
    }
}
