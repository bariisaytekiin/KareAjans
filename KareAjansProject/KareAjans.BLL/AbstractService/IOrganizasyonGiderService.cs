using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.AbstractService
{
    public interface IOrganizasyonGiderService
    {
        IEnumerable<OrganizasyonGider> GetAllOrganizasyonGider();

        string CreateOrganizasyonGider(OrganizasyonGider organizasyonGider);

        string UpdateOrganizasyonGider(OrganizasyonGider organizasyonGider);

        OrganizasyonGider FindOrganizasyonGider(int id);
    }
}
