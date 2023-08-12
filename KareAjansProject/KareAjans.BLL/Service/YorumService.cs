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
    public class YorumService : IYorumService
    {
        private readonly IRepository<Yorum> _yorumRepository;

        public YorumService(IRepository<Yorum> repository)
        {
            _yorumRepository = repository;
        }

        public string CreateYorum(Yorum yorum)
        {
            try
            {
                _yorumRepository.Create(yorum);
                return "Veri Kaydedildi.";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string DeleteYorum(Yorum yorum)
        {
            try
            {
                yorum.Status= Entity.Enums.Status.Deleted;
                _yorumRepository.Update(yorum);
                return "Veri Silindi.";


            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<Yorum> GetAllYorum()
        {
            return _yorumRepository.GetAll().ToList();
        }

        public string UpdateYorum(Yorum yorum)
        {
            try
            {
                yorum.Status = Entity.Enums.Status.Updated;
                return _yorumRepository.Update(yorum);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
