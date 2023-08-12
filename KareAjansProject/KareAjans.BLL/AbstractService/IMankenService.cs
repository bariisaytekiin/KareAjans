using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.AbstractService
{
    public interface IMankenService
    {
        IEnumerable<Manken> GetAllManken();
        string CreateManken(Manken manken);
        string UpdateManken(Manken manken);
        string DeleteManken(Manken manken);
        Manken FindManken(int id);
        IEnumerable<Manken> GetAllDeletedManken();
    }
}
