using KareAjans.BLL.Abstract;
using KareAjans.DAL.Context;
using KareAjans.Entity.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly KareAjansContext _context;
        private readonly DbSet<T> _entities;

        public BaseRepository(KareAjansContext context)
        {
            _context = context;
            _entities=_context.Set<T>();//T gönderilen hangi class ise ona göre işlemler yapacak.Gelen classı set edip _entitiese aktarmış oluyoruz.
        }


        public string Create(T entity)
        {
            try
            {
                _entities.Add(entity);
                _context.SaveChanges();
                return "Veri Kaydedildi.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(T entity)
        {
            var deleted = GetById(entity.Id);
            deleted.Status=Entity.Enums.Status.Deleted;
            //Bu aslında bir güncelleme işlemi olduğu için update gönderiyoruz.
            Update(deleted);
            return "Veri Silindi.";

        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList().Where(x=>x.Status==Entity.Enums.Status.Created||x.Status==Entity.Enums.Status.Updated);
        }

        public T GetById(int id)
        {
            var entity = _entities.Find(id);
            return entity;

        }

        public string Update(T entity)
        {

            string result = "";
            try
            {
                switch (entity.Status)
                {
                    case Entity.Enums.Status.Updated:
                        entity.Status = Entity.Enums.Status.Updated;
                        _context.Entry(entity).State=EntityState.Modified;
                        _context.SaveChanges();
                        result = "Veri Güncellendi.";
                        break;

                    case Entity.Enums.Status.Deleted:
                        entity.Status = Entity.Enums.Status.Deleted;
                        _context.SaveChanges();
                        result = "Veri Güncellendi.";
                        break;
                }
            }
            catch (Exception ex)
            {

                result=ex.Message;
            } 
            return result;
        }
    }
}
