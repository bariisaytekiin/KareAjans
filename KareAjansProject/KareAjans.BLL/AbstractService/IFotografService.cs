using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.AbstractService
{
    public interface IFotografService
    {
        IEnumerable<Fotograf> GetAllFotograf();

        string CreateFotograf(Fotograf fotograf);

        string DeleteFotograf(Fotograf fotograf);
    }
}
