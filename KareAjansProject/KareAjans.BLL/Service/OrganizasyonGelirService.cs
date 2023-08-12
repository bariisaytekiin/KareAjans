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
    public class OrganizasyonGelirService : IOrganizasyonGelirService
    {
        private readonly IRepository<OrganizasyonGelir> _organizasyonGelirRepository;

        public OrganizasyonGelirService(IRepository<OrganizasyonGelir> repository)
        {
            _organizasyonGelirRepository = repository;
        }
        public string CreateOrganizasyonGelir(OrganizasyonGelir organizasyonGelir)
        {
            try
            {
                _organizasyonGelirRepository.Create(organizasyonGelir);
                return "Veri Oluşturuldu.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public OrganizasyonGelir FindOrganizasyonGelir(int id)
        {
            return _organizasyonGelirRepository.GetById(id);
        }

        public IEnumerable<OrganizasyonGelir> GetAllOrganizasyonGelir()
        {
            return _organizasyonGelirRepository.GetAll().ToList();
        }

        public string UpdateOrganizasyonGelir(OrganizasyonGelir organizasyonGelir)
        {
            try
            {
                organizasyonGelir.Status = Entity.Enums.Status.Updated;
                return _organizasyonGelirRepository.Update(organizasyonGelir);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
