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
    public class FotografService : IFotografService
    {
        private readonly Abstract.IRepository<Fotograf> _fotografRepository;

        public FotografService(IRepository<Fotograf> repository )
        {
            _fotografRepository = repository;
        }

        public string CreateFotograf(Fotograf fotograf)
        {
            try
            {
                _fotografRepository.Create(fotograf);
                return "Veri Oluşturuldu.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteFotograf(Fotograf fotograf)
        {
            try
            {
                fotograf.Status = Entity.Enums.Status.Deleted;
                _fotografRepository.Update(fotograf);
                return "Veri Silindi.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public IEnumerable<Fotograf> GetAllFotograf()
        {
           return _fotografRepository.GetAll().ToList();
        }



    }
}
