using KareAjans.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        //List
        IEnumerable<T> GetAll();

        //Create
        string Create(T entity);

        //Delete
        string Delete(T entity);

        //Update
        string Update(T entity);

        //Find
        T  GetById(int id);
    }
}
