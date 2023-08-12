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
    public class OrganizasyonService : IOrganizasyonService
    {
        private readonly IRepository<Organizasyon> _organizasyonRepository;

        public OrganizasyonService(IRepository<Organizasyon> repository)
        {
            _organizasyonRepository = repository;
        }

        public string CreateOrganizasyon(Organizasyon organizasyon)
        {
            try
            {
                _organizasyonRepository.Create(organizasyon);
                return "Veri Oluşturuldu.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteOrganizasyon(Organizasyon organizasyon)
        {
            try
            {
                organizasyon.Status = Entity.Enums.Status.Deleted;
                _organizasyonRepository.Update(organizasyon);
                return "Veri Silindi.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Organizasyon FindOrganizasyon(int id)
        {
            return _organizasyonRepository.GetById(id);
        }

        public IEnumerable<Organizasyon> GetAllOrganizasyon()
        {
            return _organizasyonRepository.GetAll().ToList();
        }

        public string UpdateOrganizasyon(Organizasyon organizasyon)
        {
            try
            {
                organizasyon.Status = Entity.Enums.Status.Updated;
                return _organizasyonRepository.Update(organizasyon);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
