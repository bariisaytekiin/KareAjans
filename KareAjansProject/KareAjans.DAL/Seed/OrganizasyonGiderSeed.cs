using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.DAL.Seed
{
    internal class OrganizasyonGiderSeed
    {
        public static List<OrganizasyonGider> organizasyonGiderleri = new List<OrganizasyonGider>()
        { 
        new OrganizasyonGider(){Id=1,OrganizasyonId=1,MankenId=1,Butce=25000,GunSayisi=5,OgunUcreti=150,KonaklamaUcreti=500,GunlukUcret=500},
        new OrganizasyonGider(){Id=2,OrganizasyonId=1,MankenId=2,Butce=25000,GunSayisi=5,OgunUcreti=150,KonaklamaUcreti=500,GunlukUcret=1000},
        new OrganizasyonGider(){Id=3,OrganizasyonId=2,MankenId=3,Butce=25000,GunSayisi=2,OgunUcreti=150,KonaklamaUcreti=500,KategoriUcMankenSayisi=2},
        new OrganizasyonGider(){Id=4,OrganizasyonId=2,MankenId=4,Butce=25000,GunSayisi=2,OgunUcreti=150,KonaklamaUcreti=500,KategoriUcMankenSayisi=2},
        };
    }
}
