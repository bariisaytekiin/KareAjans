using KareAjans.Entity.Base;
using KareAjans.Entity.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace KareAjans.Entity.Entities
{
    public class Manken:BaseEntity
    {
        public Manken()
        {
            Fotograflar = new List<Fotograf>();
            Yorumlar = new List<Yorum>();
        }
        [Required]
        [MaxLength(35)]
        public string Ad { get; set; }
        [Required]
        [MaxLength(25)]
        public string Soyad { get; set; }
        [Required]
        [MaxLength(12)]
        public string TelefonNo { get; set; }
        [MaxLength(12)]
        public string TelefonNo2 { get; set; }
        [Required]
        [MaxLength(255)]
        public string Adres { get; set; }
        [Required]
        public Cinsiyet Cinsiyet { get; set; }
        [Required]
        public AyakkabıNo AyakkabıNo { get; set; }
        [Required]
        public Beden Beden { get; set; }
        [Required]
        public decimal Kilo { get; set; }
        [Required]
        public short Boy { get; set; }
        [Required]
        public SacRengi SacRengi { get; set; }
        [Required]
        public GozRengi GozRengi { get; set; }
        [Required]
        public bool SehirDisiCalisma { get; set; }
        [Required]
        public bool Ehliyet { get; set; }
        public string? Özellik { get; set; }
        [Required]
        public string? YabanciDil { get; set; }
        [Required]
        public DateTime DogumTarihi { get; set; }
        [Required]
        public MankenKategori Kategori { get; set; }
        [Required]
        public string Email { get; set; }

        public string? UserId{ get; set; }




        public IdentityUser User { get; set; }


        //Mapping
        public virtual List<Yorum> Yorumlar { get; set; }
        public virtual List<Fotograf> Fotograflar { get; set; }

    }
}
