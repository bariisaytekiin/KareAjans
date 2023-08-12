using KareAjans.Entity.Entities;

namespace KareAjans.MVC.Models.ViewModel
{
    public class OrganizasyonGeliGiderVM
    {
        public List<Organizasyon> Organizasyonlar { get; set; }
        public List<Manken> Mankenler { get; set; }
        public List<OrganizasyonGider> OrganizasyonGiderleri { get; set; }

        public List<Adres> Adresler { get; set; }   
    }
}
