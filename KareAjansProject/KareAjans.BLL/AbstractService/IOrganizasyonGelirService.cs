using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.AbstractService
{
    public interface IOrganizasyonGelirService
    {
        IEnumerable<OrganizasyonGelir> GetAllOrganizasyonGelir();

        string CreateOrganizasyonGelir(OrganizasyonGelir organizasyonGelir);

        string UpdateOrganizasyonGelir(OrganizasyonGelir organizasyonGelir);

        OrganizasyonGelir FindOrganizasyonGelir(int id);
    }
}
