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
    public class OrganizasyonGiderService : IOrganizasyonGiderService
    {
        private readonly IRepository<OrganizasyonGider> _organizasyonGiderRepository;

        public OrganizasyonGiderService(IRepository<OrganizasyonGider> repository)
        {
            _organizasyonGiderRepository = repository;
        }
        public string CreateOrganizasyonGider(OrganizasyonGider organizasyonGider)
        {
            try
            {
                _organizasyonGiderRepository.Create(organizasyonGider);
                return "Veri Oluşturuldu.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public OrganizasyonGider FindOrganizasyonGider(int id)
        {
            return _organizasyonGiderRepository.GetById(id);
        }

        public IEnumerable<OrganizasyonGider> GetAllOrganizasyonGider()
        {
            return _organizasyonGiderRepository.GetAll().ToList();
        }

        public string UpdateOrganizasyonGider(OrganizasyonGider organizasyonGider)
        {
            try
            {
                organizasyonGider.Status = Entity.Enums.Status.Updated;
                return _organizasyonGiderRepository.Update(organizasyonGider);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
