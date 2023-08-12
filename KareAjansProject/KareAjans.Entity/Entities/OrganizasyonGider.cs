using KareAjans.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.Entity.Entities
{
    public class OrganizasyonGider:BaseEntity 
    {
        [Required]
        public int OrganizasyonId { get; set; }
        [Required]
        public int MankenId { get; set; }
        [Required]
        public decimal Butce { get; set; }
        [Required]
        public int GunSayisi { get; set; }
        [Required]
        public decimal OgunUcreti { get; set; }
        [Required]
        public decimal KonaklamaUcreti{ get; set; }
        
        public decimal GunlukUcret { get; set; }
        [Required]
        public decimal? GelirinYuzdeYirmisi {
            get
            {
                return (Butce * 0.2m)/KategoriUcMankenSayisi;
            }
        }
       
        public int KategoriUcMankenSayisi { get; set; }





        public Organizasyon Organizasyon { get; set; }
        public Manken Manken { get; set; }
    }
}
