namespace Kareajans.Common
{
    public class CartItem
    {
       
        public int Id { get; set; }
        public string MankenAdi { get; set; }
        public string MankenSoyadi { get; set; }
        public int MankenBoyu { get; set; }
        public decimal MankenKilosu { get; set; }
        public KareAjans.Entity.Enums.MankenKategori Kategori  { get; set; }
        public string OrganizasyonAdresi { get; set; }
        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }

    }
}
