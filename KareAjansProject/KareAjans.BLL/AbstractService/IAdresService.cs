using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.AbstractService
{
    public interface IAdresService
    {
        IEnumerable<Adres> GetAllAdres();
        string CreateAdres(Adres Adres);
        string UpdateAdres(Adres Adres);
        string DeleteAdres(Adres Adres);

    }
}
