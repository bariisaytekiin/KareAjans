using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.AbstractService
{
    public interface IYorumService
    {
        IEnumerable<Yorum> GetAllYorum();

        string CreateYorum(Yorum yorum);

        string UpdateYorum(Yorum yorum);
        string DeleteYorum(Yorum yorum);
    }
}
