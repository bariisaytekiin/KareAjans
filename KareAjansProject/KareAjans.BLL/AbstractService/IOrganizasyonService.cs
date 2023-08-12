using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.AbstractService
{
    public interface IOrganizasyonService
    {
        IEnumerable<Organizasyon> GetAllOrganizasyon();

        string CreateOrganizasyon(Organizasyon organizasyon);

        string UpdateOrganizasyon(Organizasyon organizasyon);
        string DeleteOrganizasyon(Organizasyon organizasyon);
        Organizasyon FindOrganizasyon(int id);
    }
}
