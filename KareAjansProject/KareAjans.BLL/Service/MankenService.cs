using KareAjans.BLL.Abstract;
using KareAjans.BLL.AbstractService;
using KareAjans.DAL.Context;
using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.Service
{
    public class MankenService : IMankenService
    {
        private IRepository<Manken> _mankenRepository;//Oluşturduğumuz interface göndereceğimiz tipi belirtiyoruz bağlantısını kuruyoruz.
        private readonly KareAjansContext _context;

        public MankenService(IRepository<Manken> repository,KareAjansContext context)
        {
            _mankenRepository = repository;
            _context = context;
        }


        public string CreateManken(Manken manken)
        {
            try
            {
                _mankenRepository.Create(manken);
                return "Veri Oluşturuldu.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteManken(Manken manken)
        {
            try
            {
                manken.Status = Entity.Enums.Status.Deleted;
                _mankenRepository.Update(manken);
                return "Veri Silindi.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Manken FindManken(int id)
        {
            return _mankenRepository.GetById(id);
        }

        public IEnumerable<Manken> GetAllDeletedManken()
        {
            return _context.Mankenler.ToList();
        }

        public IEnumerable<Manken> GetAllManken()
        {
            return _mankenRepository.GetAll().ToList();
        }

        public string UpdateManken(Manken manken)
        {
            try
            {
                manken.Status = Entity.Enums.Status.Updated;
                return _mankenRepository.Update(manken);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
