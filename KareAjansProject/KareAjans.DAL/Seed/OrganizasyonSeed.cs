using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.DAL.Seed
{
    internal class OrganizasyonSeed
    {
        public static List<Organizasyon> organizasyonlar=new List<Organizasyon>() 
        {
        new Organizasyon(){Id=1,OrganizasyonAdi="A standı",BaslangicTarihi=new DateTime(2023,7,10),BitisTarihi=new DateTime(2023,7,15),AdresId=1},
        new Organizasyon(){Id=2,OrganizasyonAdi="A standı",BaslangicTarihi=new DateTime(2023,5,10),BitisTarihi=new DateTime(2023,5,15),AdresId=2},
        new Organizasyon(){Id=3,OrganizasyonAdi="A standı",BaslangicTarihi=new DateTime(2023,4,10),BitisTarihi=new DateTime(2023,4,15),AdresId=2},
        };
    }
}
