using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.DAL.Seed
{
    internal class OrganizasyonGelirSeed
    {
        public static List<OrganizasyonGelir> organizasyonGelirleri=new List<OrganizasyonGelir>() 
        {
        new OrganizasyonGelir(){Id=1,OrganizasyonId=1,Butce=25000},
        new OrganizasyonGelir(){Id=2,OrganizasyonId=2,Butce=35000},
        new OrganizasyonGelir(){Id=3,OrganizasyonId=3,Butce=45000},
        };
    }
}
