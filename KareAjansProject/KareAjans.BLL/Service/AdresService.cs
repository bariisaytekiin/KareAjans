using KareAjans.BLL.Abstract;
using KareAjans.BLL.AbstractService;
using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.BLL.Service
{
    public class AdresService : IAdresService
    {
        private IRepository<Adres> _adresRepository;
        public AdresService(IRepository<Adres> repository)
        {
            _adresRepository = repository;
        }
        public string CreateAdres(Adres Adres)
        {
            try
            {
                _adresRepository.Create(Adres);
                return "Veri Oluşturuldu.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteAdres(Adres Adres)
        {
            try
            {
                Adres.Status = Entity.Enums.Status.Deleted;
                _adresRepository.Update(Adres);
                return "Veri Silindi.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public IEnumerable<Adres> GetAllAdres()
        {
            return _adresRepository.GetAll().ToList();
        }

        public string UpdateAdres(Adres Adres)
        {
            try
            {
                Adres.Status = Entity.Enums.Status.Updated;
                return _adresRepository.Update(Adres);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
